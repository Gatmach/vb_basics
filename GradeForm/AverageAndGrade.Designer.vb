<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AverageAndGrade
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        ExitButton = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(100, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 32)
        Label1.TabIndex = 0
        Label1.Text = "Average:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(111, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 32)
        Label2.TabIndex = 1
        Label2.Text = "Grade:"
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(268, 299)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(117, 46)
        ExitButton.TabIndex = 2
        ExitButton.Text = "EXIT"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(231, 190)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(162, 39)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(231, 72)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(162, 39)
        TextBox2.TabIndex = 4
        ' 
        ' AverageAndGrade
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ExitButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AverageAndGrade"
        Text = "AverageAndGrade"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
