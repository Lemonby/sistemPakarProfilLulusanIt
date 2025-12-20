Imports MySql.Data.MySqlClient
Imports sistemPakarProfilLulusanIt.moduleKoneksi

Public Class adminDashboard
    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(221, 136, 207)

        ' Set form state dan size
        Me.WindowState = FormWindowState.Maximized

        ' Setup button navbar (hilangkan border)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0
            End If
        Next

        ' Setup responsive layout
        SetupResponsiveLayout()

        ' LOAD SUMMARY CARDS LANGSUNG SAAT FORM LOAD
        LoadSummaryCardsToPanel()

        ' Tampilkan panel pertama dan load data
        ShowPanel("A")
        LoadDashboardData()
    End Sub

    ' ========== LOAD SUMMARY CARDS KE PANEL (DIPANGGIL SAAT FORM LOAD) ==========
    Private Sub LoadSummaryCardsToPanel()
        ' Pastikan PanelDashboardContent ada
        If PanelDashboardContent Is Nothing Then Return

        ' Clear controls dulu
        PanelDashboardContent.Controls.Clear()
        PanelDashboardContent.AutoScroll = True

        ' Buat dan tambahkan summary cards
        Dim summaryCards = CreateSummaryCards()

        ' Tambahkan cards dengan posisi Y=0 (menempel di atas)
        For Each card As Panel In summaryCards
            PanelDashboardContent.Controls.Add(card)
        Next
    End Sub

    ' ========== SETUP RESPONSIVE LAYOUT ==========
    Private Sub SetupResponsiveLayout()
        ' Panel content mengisi sisa space dan menempel di atas
        If PanelDashboardContent IsNot Nothing Then
            PanelDashboardContent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            ' Pastikan panel menempel di atas parent
            PanelDashboardContent.Location = New Point(PanelDashboardContent.Location.X, 0)
        End If

        If PanelKelolaAkunContent IsNot Nothing Then
            PanelKelolaAkunContent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            ' Pastikan panel kelola akun memiliki lokasi dan ukuran yang sama dengan panel dashboard
            PanelKelolaAkunContent.Location = PanelDashboardContent.Location
            PanelKelolaAkunContent.Size = PanelDashboardContent.Size
        End If

        ' DataGridView juga responsive
        If DataGridView1 IsNot Nothing Then
            DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        End If

        ' Subscribe ke resize event
        AddHandler Me.Resize, AddressOf adminDashboard_Resize
    End Sub

    ' ========== HANDLE FORM RESIZE ==========
    Private Sub adminDashboard_Resize(sender As Object, e As EventArgs)
        ' Reload data saat form diresize
        If PanelDashboardContent.Visible Then
            LoadDashboardData()
        End If
    End Sub

    ' Method untuk show/hide panel
    Private Sub ShowPanel(panelName As String)
        ' Hide semua panel terlebih dahulu
        PanelDashboardContent.Visible = False
        PanelKelolaAkunContent.Visible = False

        ' Show panel yang dipilih
        Select Case panelName
            Case "A"
                PanelDashboardContent.Visible = True
                PanelDashboardContent.BringToFront()
            Case "B"
                PanelKelolaAkunContent.Visible = True
                PanelKelolaAkunContent.BringToFront()
        End Select
    End Sub

    Private Sub BtnDashboardContent_Click(sender As Object, e As EventArgs) Handles BtnDashboardContent.Click
        ShowPanel("A")
        LoadDashboardData()
    End Sub

    Private Sub BtnKelolaAkunContent_Click(sender As Object, e As EventArgs) Handles BtnKelolaAkunContent.Click
        ShowPanel("B")
        ' Load data hasil profil user ke DataGridView
        loadDataB()
    End Sub

    ' ========== LOAD DASHBOARD DATA (HANYA PROFILE CARDS) ==========
    Private Sub LoadDashboardData()
        ' Jangan clear semua controls, karena summary cards sudah ada di atas
        ' Hanya tambahkan profile cards setelah summary cards

        ' Hapus profile cards yang lama (jika ada)
        Dim controlsToRemove As New List(Of Control)
        For Each ctrl As Control In PanelDashboardContent.Controls
            ' Hapus semua kecuali summary cards (yang punya Tag "SummaryCard")
            If ctrl.Tag IsNot Nothing AndAlso ctrl.Tag.ToString() = "ProfileCard" Then
                controlsToRemove.Add(ctrl)
            End If
        Next

        For Each ctrl In controlsToRemove
            PanelDashboardContent.Controls.Remove(ctrl)
        Next

        ' Load profile cards mulai dari Y position setelah summary cards
        ' Y = 0 + 120 (tinggi summary card) + 15 (margin)
        Dim yPosition As Integer = 135

        LoadProfileCards(yPosition)
    End Sub

    ' ========== CREATE 3 SUMMARY CARDS ==========
    Private Function CreateSummaryCards() As List(Of Panel)
        Dim cards As New List(Of Panel)
        Dim cardWidth As Integer = (PanelDashboardContent.ClientSize.Width - 40) \ 3 ' Kurangi margin
        If cardWidth < 200 Then cardWidth = 200

        Using conn As MySqlConnection = GetConnection()
            If conn Is Nothing Then
                MessageBox.Show("Koneksi database gagal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return cards
            End If

            Try
                ' Card 1: Total User (exclude admin)
                Dim queryTotalUser As String = "SELECT COUNT(*) FROM tb_users WHERE role != 'admin'"
                Dim cmdTotalUser As New MySqlCommand(queryTotalUser, conn)
                Dim totalUser As Integer = Convert.ToInt32(cmdTotalUser.ExecuteScalar())

                Dim card1 As Panel = CreateSummaryCard(
                    "Total User",
                    totalUser.ToString(),
                    Color.FromArgb(52, 152, 219),
                    "👥",
                    0
                )
                cards.Add(card1)

                ' Card 2: Total Profil/Pekerjaan
                Dim queryTotalProfil As String = "SELECT COUNT(*) FROM tb_profil"
                Dim cmdTotalProfil As New MySqlCommand(queryTotalProfil, conn)
                Dim totalProfil As Integer = Convert.ToInt32(cmdTotalProfil.ExecuteScalar())

                Dim card2 As Panel = CreateSummaryCard(
                    "Total Profil Pekerjaan",
                    totalProfil.ToString(),
                    Color.FromArgb(46, 204, 113),
                    "💼",
                    cardWidth + 5 ' Kurangi spacing
                )
                cards.Add(card2)

                ' Card 3: Total User yang Sudah Test
                Dim queryTotalTest As String = "SELECT COUNT(DISTINCT userId) FROM tb_konsultasi"
                Dim cmdTotalTest As New MySqlCommand(queryTotalTest, conn)
                Dim totalTest As Integer = Convert.ToInt32(cmdTotalTest.ExecuteScalar())

                Dim card3 As Panel = CreateSummaryCard(
                    "User Sudah Test",
                    totalTest.ToString(),
                    Color.FromArgb(155, 89, 182),
                    "✅",
                    (cardWidth + 5) * 2 ' Kurangi spacing
                )
                cards.Add(card3)

            Catch ex As Exception
                MessageBox.Show("Error loading summary: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return cards
    End Function

    ' ========== CREATE SINGLE SUMMARY CARD ==========
    Private Function CreateSummaryCard(title As String, value As String, bgColor As Color, icon As String, xPos As Integer) As Panel
        Dim cardWidth As Integer = (PanelDashboardContent.ClientSize.Width - 40) \ 3
        If cardWidth < 200 Then cardWidth = 200

        Dim card As New Panel()
        card.Width = cardWidth
        card.Height = 120
        card.BackColor = bgColor
        card.Location = New Point(5 + xPos, 5) ' Posisi Y=5 (hampir menempel di atas)
        card.BorderStyle = BorderStyle.None
        card.Padding = New Padding(15)
        card.Tag = "SummaryCard" ' Tag untuk identifikasi

        ' Icon/Emoji
        Dim lblIcon As New Label()
        lblIcon.Text = icon
        lblIcon.Font = New Font("Segoe UI", 28, FontStyle.Regular)
        lblIcon.Location = New Point(15, 15)
        lblIcon.AutoSize = True
        lblIcon.ForeColor = Color.White
        card.Controls.Add(lblIcon)

        ' Title
        Dim lblTitle As New Label()
        lblTitle.Text = title
        lblTitle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(75, 20)
        lblTitle.AutoSize = True
        card.Controls.Add(lblTitle)

        ' Value
        Dim lblValue As New Label()
        lblValue.Text = value
        lblValue.Font = New Font("Segoe UI", 32, FontStyle.Bold)
        lblValue.ForeColor = Color.White
        lblValue.Location = New Point(75, 45)
        lblValue.AutoSize = True
        card.Controls.Add(lblValue)

        ' Hover effect
        AddHandler card.MouseEnter, Sub()
                                        card.BackColor = Color.FromArgb(
                                            Math.Min(bgColor.R + 20, 255),
                                            Math.Min(bgColor.G + 20, 255),
                                            Math.Min(bgColor.B + 20, 255)
                                        )
                                    End Sub

        AddHandler card.MouseLeave, Sub()
                                        card.BackColor = bgColor
                                    End Sub

        Return card
    End Function

    ' ========== LOAD PROFILE CARDS KE PANEL ==========
    Private Sub LoadProfileCards(startY As Integer)
        Using conn As MySqlConnection = GetConnection()
            If conn Is Nothing Then Return

            Try
                ' Query untuk ambil data profil + hitung jumlah user per profil
                Dim query As String = "
                    SELECT 
                        p.kodeProfile,
                        p.namaProfile,
                        p.deskripsi,
                        COUNT(k.userId) as totalUser
                    FROM tb_profil p
                    LEFT JOIN tb_konsultasi k ON p.kodeProfile = k.hasilKodeProfile
                    GROUP BY p.kodeProfile, p.namaProfile, p.deskripsi
                    ORDER BY p.kodeProfile ASC"

                Dim cmd As New MySqlCommand(query, conn)
                Dim yPosition As Integer = startY

                Using rd As MySqlDataReader = cmd.ExecuteReader()
                    While rd.Read()
                        ' Buat card untuk setiap profil
                        Dim profileCard As Panel = CreateProfileCard(
                            rd("kodeProfile").ToString(),
                            rd("namaProfile").ToString(),
                            rd("deskripsi").ToString(),
                            Convert.ToInt32(rd("totalUser")),
                            yPosition
                        )
                        PanelDashboardContent.Controls.Add(profileCard)
                        yPosition += profileCard.Height + 10
                    End While
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading profile cards: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ========== CREATE PROFILE CARD (RESPONSIVE) ==========
    Private Function CreateProfileCard(kodeProfile As String, namaProfile As String, deskripsi As String, totalUser As Integer, yPos As Integer) As Panel
        ' Hitung lebar card berdasarkan panel parent (dengan margin untuk scrollbar)
        Dim cardWidth As Integer = PanelDashboardContent.ClientSize.Width - 20 ' Kurangi margin
        If cardWidth < 400 Then cardWidth = 400 ' Minimum width

        ' Panel utama sebagai Card
        Dim card As New Panel()
        card.Width = cardWidth
        card.Height = 110
        card.BackColor = Color.White
        card.BorderStyle = BorderStyle.FixedSingle
        card.Location = New Point(5, yPos) ' Margin kiri hanya 5px
        card.Padding = New Padding(10)
        card.Tag = "ProfileCard" ' Tag untuk identifikasi

        ' ========== ICON/IMAGE ==========
        Dim iconBox As New PictureBox()
        iconBox.Width = 80
        iconBox.Height = 80
        iconBox.Location = New Point(10, 15)
        iconBox.BackColor = Color.FromArgb(240, 240, 240)
        iconBox.BorderStyle = BorderStyle.FixedSingle
        iconBox.SizeMode = PictureBoxSizeMode.CenterImage

        ' Label icon sebagai placeholder
        Dim lblIcon As New Label()
        lblIcon.Text = kodeProfile
        lblIcon.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblIcon.ForeColor = Color.FromArgb(155, 89, 182)
        lblIcon.TextAlign = ContentAlignment.MiddleCenter
        lblIcon.Dock = DockStyle.Fill
        iconBox.Controls.Add(lblIcon)
        card.Controls.Add(iconBox)

        ' ========== NAMA PROFIL ==========
        Dim lblNama As New Label()
        lblNama.Text = namaProfile
        lblNama.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblNama.Location = New Point(100, 15)
        lblNama.AutoSize = True
        card.Controls.Add(lblNama)

        ' ========== LABEL "HITS" (Badge) ==========
        Dim lblBadge As New Label()
        lblBadge.Text = "Hits"
        lblBadge.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblBadge.BackColor = Color.FromArgb(46, 204, 113)
        lblBadge.ForeColor = Color.White
        lblBadge.AutoSize = True
        lblBadge.Padding = New Padding(5, 2, 5, 2)
        lblBadge.Location = New Point(100 + lblNama.PreferredWidth + 10, 18)
        card.Controls.Add(lblBadge)

        ' ========== DESKRIPSI (RESPONSIVE WIDTH) ==========
        Dim lblDeskripsi As New Label()
        lblDeskripsi.Text = deskripsi
        lblDeskripsi.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        lblDeskripsi.ForeColor = Color.Gray
        lblDeskripsi.Location = New Point(100, 45)
        ' Lebar deskripsi menyesuaikan dengan card width
        lblDeskripsi.MaximumSize = New Size(cardWidth - 280, 0)
        lblDeskripsi.AutoSize = True
        card.Controls.Add(lblDeskripsi)

        ' ========== TOTAL PROFIL (Kanan, RESPONSIVE POSITION) ==========
        Dim lblTotalLabel As New Label()
        lblTotalLabel.Text = "Total Profil"
        lblTotalLabel.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblTotalLabel.ForeColor = Color.Black
        lblTotalLabel.Location = New Point(cardWidth - 150, 15)
        lblTotalLabel.AutoSize = True
        card.Controls.Add(lblTotalLabel)

        Dim lblTotal As New Label()
        lblTotal.Text = totalUser.ToString()
        lblTotal.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        lblTotal.ForeColor = Color.FromArgb(155, 89, 182)
        lblTotal.Location = New Point(cardWidth - 150, 40)
        lblTotal.AutoSize = True
        card.Controls.Add(lblTotal)

        ' ========== HOVER EFFECT ==========
        AddHandler card.MouseEnter, Sub()
                                        card.BackColor = Color.FromArgb(250, 250, 250)
                                        card.Cursor = Cursors.Hand
                                    End Sub

        AddHandler card.MouseLeave, Sub()
                                        card.BackColor = Color.White
                                    End Sub

        ' ========== CLICK EVENT ==========
        AddHandler card.Click, Sub()
                                   MessageBox.Show($"Detail Profil:{vbCrLf}{vbCrLf}" &
                                                 $"Kode: {kodeProfile}{vbCrLf}" &
                                                 $"Nama: {namaProfile}{vbCrLf}" &
                                                 $"Total User: {totalUser}{vbCrLf}{vbCrLf}" &
                                                 $"Deskripsi:{vbCrLf}{deskripsi}",
                                                 "Detail Profil",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information)
                               End Sub

        Return card
    End Function

    ' ========== LOAD DATA B (KELOLA AKUN) ==========
    Private Sub loadDataB()
        Using conn As MySqlConnection = GetConnection()
            If conn Is Nothing Then
                MessageBox.Show("Koneksi database gagal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                Dim query As String = "SELECT u.userName AS username, 
                                          IFNULL(u.prodi, '-') AS prodi, 
                                          IFNULL(p.namaProfile, '-') AS profile, 
                                          IFNULL(CONCAT(ROUND(k.hasilNilaiCf * 100, 2), '%'), '-') AS tingkat_keakuratan
                                   FROM tb_users u
                                   LEFT JOIN tb_konsultasi k ON u.userId = k.userId
                                   LEFT JOIN tb_profil p ON k.hasilKodeProfile = p.kodeProfile
                                   WHERE u.role != 'admin'
                                   ORDER BY u.userId ASC"

                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Setup DataGridView
                DataGridView1.DataSource = table
                DataGridView1.ReadOnly = True
                DataGridView1.AllowUserToAddRows = False
                DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DataGridView1.MultiSelect = False
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                ' Format header jika ada data
                If table.Rows.Count > 0 Then
                    DataGridView1.Columns("username").HeaderText = "Username"
                    DataGridView1.Columns("prodi").HeaderText = "Program Studi"
                    DataGridView1.Columns("profile").HeaderText = "Profil Lulusan"
                    DataGridView1.Columns("tingkat_keakuratan").HeaderText = "Tingkat Keakuratan"

                    ' Styling DataGridView
                    DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(155, 89, 182)
                    DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                    DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                    DataGridView1.ColumnHeadersDefaultCellStyle.Padding = New Padding(5)
                    DataGridView1.ColumnHeadersHeight = 40
                    DataGridView1.EnableHeadersVisualStyles = False

                    ' Row styling
                    DataGridView1.RowTemplate.Height = 35
                    DataGridView1.DefaultCellStyle.Padding = New Padding(5)
                    DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
                End If

            Catch ex As Exception
                MessageBox.Show("Gagal menampilkan data hasil profil user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub panelMenuDashboard_Paint(sender As Object, e As PaintEventArgs) Handles panelMenuDashboard.Paint
        ' Event handler untuk paint - bisa dikosongkan atau dihapus jika tidak dipakai
    End Sub

    Private Sub PanelKelolaAkunContent_Paint(sender As Object, e As PaintEventArgs) Handles PanelKelolaAkunContent.Paint

    End Sub
End Class