'Joshua Hitchcock
'Store Form

Public Class frmMain

    'This calculats order totals.
    'first version was with button click only, added handles for textchanged to give a running total on the form, this makes the button to calculate obsolete however.
    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click, txtCamera.TextChanged, txtMp3.TextChanged, txtMouse.TextChanged, txtKey.TextChanged, txtTablet.TextChanged, txtBlTooth.TextChanged, txtJoystick.TextChanged, txtPen.TextChanged
        lblCameraCost.Text = Val(txtCamera.Text) * 49.95
        lblMp3Cost.Text = Val(txtMp3.Text) * 79.99
        lblMouseCost.Text = Val(txtMouse.Text) * 39.95
        lblKeyCost.Text = Val(txtKey.Text) * 25
        lblTabletCost.Text = Val(txtTablet.Text) * 50
        lblBlToothCost.Text = Val(txtBlTooth.Text) * 15
        lblJoystickCost.Text = Val(txtJoystick.Text) * 20
        lblPenCost.Text = Val(txtPen.Text) * 99
        lblTotalCost.Text = "$" & Val(lblCameraCost.Text) + Val(lblMp3Cost.Text) + Val(lblMouseCost.Text) + Val(lblKeyCost.Text) + Val(lblTabletCost.Text) + Val(lblBlToothCost.Text) + Val(lblJoystickCost.Text) + Val(lblPenCost.Text)
        lblTotalItems.Text = Val(txtCamera.Text) + Val(txtMp3.Text) + Val(txtMouse.Text) + Val(txtKey.Text) + Val(txtTablet.Text) + Val(txtBlTooth.Text) + Val(txtJoystick.Text) + Val(txtPen.Text)
    End Sub

    'Sets the focus to the first Text box on the form
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCamera.Focus()
    End Sub

    'Clears all user input on the form
    Private Sub btmClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmClear.Click
        Me.txtCamera.Text = "0"
        Me.txtMp3.Text = "0"
        Me.txtMouse.Text = "0"
        Me.txtKey.Text = "0"
        Me.txtTablet.Text = "0"
        Me.txtBlTooth.Text = "0"
        Me.txtJoystick.Text = "0"
        Me.txtPen.Text = "0"
    End Sub

    'Exits the program
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
