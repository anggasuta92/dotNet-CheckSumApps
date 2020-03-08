Public Class frmCheckSum
    Public Const jmlBit As Integer = 16
    Dim hasilAkhir As String

    Private Sub txtBineary_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBineary.KeyDown
        If e.KeyCode = 13 Then
            cmdGenerate.PerformClick()
        End If
    End Sub 'menyimpan hasil per penjumlahan
    Private Sub txtBineary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBineary.KeyPress
        '48>0 49>1 8>backspace
        If (Asc(e.KeyChar) <> 48 And Asc(e.KeyChar) <> 49 And Asc(e.KeyChar) <> 8) Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub frmCheckSum_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        panelLoading.Visible = True
        txtResult.Text = ""
        txtBinearResult.Text = ""
        Application.DoEvents()

        Dim panjangInputan As Integer = Len(txtBineary.Text)
        Dim sisaPembagian As Integer = (panjangInputan Mod jmlBit)
        Dim perulangan As Integer = (Math.Floor(panjangInputan / jmlBit)) - 1

        Dim hasil As String

        If Val(sisaPembagian) <> 0 Then
            perulangan = perulangan + 1
        End If

        '================= jika inputan kurang dari 16 karakter maka tambahkan angka 0 di depan agar memenuhi 16 karakter ==============
        If panjangInputan < jmlBit Then
            txtBineary.Text = Microsoft.VisualBasic.Right("0000000000000000" + txtBineary.Text, jmlBit)
            panjangInputan = jmlBit
        End If

        txtResult.Text = ""
        '====================== cetak result ke textbox result ===========================
        txtResult.Text = txtResult.Text + vbCrLf + "       HASIL CHECKSUM DENGAN BILANGAN BINEAR " + jmlBit.ToString + " BIT"
        txtResult.Text = txtResult.Text + vbCrLf + "========================================================="
        txtResult.Text = txtResult.Text + vbCrLf + "Panjang inputan binear         : " + panjangInputan.ToString
        txtResult.Text = txtResult.Text + vbCrLf + "Jumlah perulangan              : " + perulangan.ToString + " kali"
        txtResult.Text = txtResult.Text + vbCrLf + "Sisa hasil bagi (MOD)          : " + sisaPembagian.ToString
        txtResult.Text = txtResult.Text + vbCrLf + "========================================================="
        txtResult.Text = txtResult.Text + vbCrLf + "               P    R    O    S    E    S"
        txtResult.Text = txtResult.Text + vbCrLf + "=========================================================" + vbCrLf

        '==================== jika hanya ada 16 karakter maka langsung di balik (proses checksum) =============
        If perulangan = 0 Then
            Dim bil = Microsoft.VisualBasic.Mid(txtBineary.Text, (panjangInputan - jmlBit + 1), jmlBit)
            txtResult.Text = txtResult.Text + vbCrLf + "        BILANGAN         : " + bil.ToString
            hasilAkhir = reverseBinear(txtBineary.Text).ToString
            txtResult.Text = txtResult.Text + vbCrLf + "      "
            txtResult.Text = txtResult.Text + vbCrLf + "        =====Convert -> Checksum====="
            txtResult.Text = txtResult.Text + vbCrLf + "        CHECKSUM   : " + hasilAkhir.ToString
            txtResult.Text = txtResult.Text + vbCrLf + "        ==============End============"
            'tampilkan hasil di textbox
            txtBinearResult.Text = "# CHECKSUM : " + hasilAkhir.ToString + " #"
            panelLoading.Visible = False
            Exit Sub
        End If
        '=======================================================================================================

        For i As Integer = 1 To perulangan
            Dim x As Integer
            '====== menampilkan progress bar ====
            x = i / perulangan * 100
            Application.DoEvents()
            ProgressBar1.Value = x
            lblPersent.Text = x.ToString + "%"


            txtResult.Text = txtResult.Text + vbCrLf + "PERULANGAN KE-" + i.ToString
            Dim bil1, bil2 As String

            '====================== penjumlahan baris pertama dan kedua =====================
            If (i <> perulangan And i = 1 And perulangan > 1) Or (i = perulangan And i = 1 And perulangan = 1) Then
                bil1 = Microsoft.VisualBasic.Mid(txtBineary.Text, (panjangInputan - jmlBit + 1), jmlBit)
                txtResult.Text = txtResult.Text + vbCrLf + "        BILANGAN 1 : " + bil1.ToString

                '===== cek jika jml bit yg diinput mencukupi atau kurang, kalau kurang ambil sisanya tambahkan 0 didepannya ======
                If sisaPembagian = 0 Then
                    If i = perulangan Then
                        bil2 = Microsoft.VisualBasic.Mid(txtBineary.Text, 1, jmlBit)
                    Else
                        bil2 = Microsoft.VisualBasic.Mid(txtBineary.Text, (panjangInputan - (jmlBit * 2) + 1), jmlBit)
                    End If
                Else
                    Dim xStart As Integer = (panjangInputan - (jmlBit * 2) + 1)
                    Dim xjmlBit = jmlBit
                    If xStart <= 0 Then
                        xStart = 1
                        xjmlBit = sisaPembagian
                    End If

                    bil2 = Microsoft.VisualBasic.Right("0000000000000000" + Microsoft.VisualBasic.Mid(txtBineary.Text, xStart, xjmlBit), jmlBit)
                End If

                txtResult.Text = txtResult.Text + vbCrLf + "        BILANGAN 2 : " + bil2.ToString

                txtResult.Text = txtResult.Text + vbCrLf + "        ------------------------------------- +"
                hasil = sumBinear(bil1, bil2)

                txtResult.Text = txtResult.Text + vbCrLf + "        HASILNYA   : " + hasil
                hasilAkhir = hasil

                '=== cek hasilnya apakah melebihi 16 bit, jika iya maka wrap around ====
                If Len(hasil) > jmlBit Then
                    txtResult.Text = txtResult.Text + vbCrLf + wrapAround(hasil)
                End If
                '====================== end penjumlahan baris pertama dan kedua =====================

            Else
                '====================== penjumlahan berikutnya =====================
                bil1 = hasilAkhir
                txtResult.Text = txtResult.Text + vbCrLf + "        BILANGAN 1 : " + bil1.ToString

                If i = perulangan Then
                    If sisaPembagian = 0 Then
                        bil2 = Microsoft.VisualBasic.Mid(txtBineary.Text, 1, jmlBit)
                    Else
                        bil2 = Microsoft.VisualBasic.Right("0000000000000000" + Microsoft.VisualBasic.Mid(txtBineary.Text, 1, sisaPembagian), jmlBit)
                    End If
                ElseIf i > 1 And perulangan > 1 Then
                    bil2 = Microsoft.VisualBasic.Mid(txtBineary.Text, (panjangInputan - ((jmlBit * i) + 1)), jmlBit)
                End If

                hasil = sumBinear(bil1, bil2)

                txtResult.Text = txtResult.Text + vbCrLf + "        BILANGAN 2 : " + bil2.ToString
                txtResult.Text = txtResult.Text + vbCrLf + "        ------------------------------------- +"
                txtResult.Text = txtResult.Text + vbCrLf + "        HASILNYA   : " + hasil

                '=== cek hasilnya apakah melebihi 16 bit, jika iya maka wrap around ====
                If Len(hasil) > jmlBit Then
                    txtResult.Text = txtResult.Text + vbCrLf + wrapAround(hasil)
                Else
                    hasilAkhir = hasil
                End If
            End If

            txtResult.Text = txtResult.Text + vbCrLf + "=========================================================" + vbCrLf
        Next

        txtResult.Text = txtResult.Text + vbCrLf + "        HASIL AKHIR: " + hasilAkhir.ToString
        txtResult.Text = txtResult.Text + vbCrLf + "      "
        txtResult.Text = txtResult.Text + vbCrLf + "        =====Convert -> Checksum====="
        txtResult.Text = txtResult.Text + vbCrLf + "        CHECKSUM   : " + reverseBinear(hasilAkhir).ToString
        txtResult.Text = txtResult.Text + vbCrLf + "        ==============End============"

        'tampilkan hasil di textbox
        txtBinearResult.Text = "# CHECKSUM : " + reverseBinear(hasilAkhir).ToString + " #"
        panelLoading.Visible = False
    End Sub

    '=================================================================== baris fungsi ==================================================
    Function sumBinear(ByVal binear1 As String, ByVal binear2 As String) As String
        Dim result As String
        Dim simpan As Integer = 0

        For i As Integer = 1 To jmlBit
            Dim bin1, bin2 As Integer
            Dim hasil As Integer = 0

            bin1 = Microsoft.VisualBasic.Mid(binear1, jmlBit - (i - 1), 1)
            bin2 = Microsoft.VisualBasic.Mid(binear2, jmlBit - (i - 1), 1)

            '==== jumlahkan dulu binear ke 1 dengan bilangan yg disimpan sebelumnya ====
            hasil = simpan + bin1
            If hasil = 2 Then
                hasil = 0
                simpan = 1
            Else
                simpan = 0
            End If

            '==== jumlahkan hasil dengan binear ke 2 ====
            hasil = hasil + bin2
            If hasil = 2 Then
                hasil = 0
                simpan = simpan + 1
            Else
                simpan = simpan + 0
            End If

            result = hasil.ToString + result

            If simpan = 1 And i = jmlBit Then
                result = simpan.ToString + result
            End If
        Next
        Return result
    End Function

    Function wrapAround(ByVal binear As String) As String
        Dim result As String

        If Len(binear) > jmlBit Then
            Dim bil1, bil2 As String
            bil1 = Microsoft.VisualBasic.Mid(binear, (Len(binear) - jmlBit + 1), jmlBit)
            bil2 = Microsoft.VisualBasic.Right("0000000000000000" + Microsoft.VisualBasic.Mid(binear, 1, (Len(binear) - jmlBit)), jmlBit)
            result = "              -------------------------------------" + vbCrLf + "              - WRAP AROUND      : " + bil1
            result = result + vbCrLf + "                                 : " + bil2
            result = result + vbCrLf + "              ------------------------------------- +"
            result = result + vbCrLf + "              - HASIL WRAP AROUND: " + sumBinear(bil1, bil2)
            hasilAkhir = sumBinear(bil1, bil2)
        End If

        Return result
    End Function
    Function reverseBinear(ByVal binear As String) As String
        Dim hasil As String = ""
        For i As Integer = 1 To Len(binear)
            Dim bil As Integer = Microsoft.VisualBasic.Mid(binear, (Len(binear) - (i - 1)), 1)
            If bil = 0 Then
                bil = 1
            Else
                bil = 0
            End If
            hasil = bil.ToString + hasil
        Next
        Return hasil
    End Function

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        txtBinearResult.Text = ""
        txtBineary.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub txtBineary_TextChanged(sender As Object, e As EventArgs) Handles txtBineary.TextChanged

    End Sub
End Class
