<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnShownumber = New Button()
        Label1 = New Label()
        txtEnterNumber = New TextBox()
        SuspendLayout()
        ' 
        ' btnShownumber
        ' 
        btnShownumber.BackColor = SystemColors.ControlLightLight
        btnShownumber.Location = New Point(398, 293)
        btnShownumber.Name = "btnShownumber"
        btnShownumber.Size = New Size(150, 58)
        btnShownumber.TabIndex = 0
        btnShownumber.Text = "Show number"
        btnShownumber.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(249, 154)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter Number"
        ' 
        ' txtEnterNumber
        ' 
        txtEnterNumber.Location = New Point(398, 154)
        txtEnterNumber.Name = "txtEnterNumber"
        txtEnterNumber.Size = New Size(150, 31)
        txtEnterNumber.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtEnterNumber)
        Controls.Add(Label1)
        Controls.Add(btnShownumber)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnShownumber As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEnterNumber As TextBox
End Class
