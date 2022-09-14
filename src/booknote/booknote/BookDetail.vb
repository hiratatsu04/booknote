Option Strict On

Public Class BookDetail
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles ReviewTrackBar.Scroll

        ReviewLabel.Text = (ReviewTrackBar.Value / 10).ToString("0.0")

    End Sub

    Private Sub BookDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ComboBoxの初期化
        For i As Integer = 1980 To 2022
            BuyYearComboBox.Items.Add(i)
            StartYearComboBox.Items.Add(i)
            EndYearComboBox.Items.Add(i)
        Next
        For i As Integer = 1 To 12
            BuyMonthComboBox.Items.Add(i)
            StartMonthComboBox.Items.Add(i)
            EndMonthComboBox.Items.Add(i)
        Next
        For i As Integer = 1 To 31
            BuyDayComboBox.Items.Add(i)
            StartDayComboBox.Items.Add(i)
            EndDayComboBox.Items.Add(i)
        Next

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

    End Sub
End Class
