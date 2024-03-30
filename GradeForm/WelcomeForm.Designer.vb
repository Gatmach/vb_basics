<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomeForm
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
        Label1 = New Label()
        Label2 = New Label()
        GetStartedButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(141, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(363, 32)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME TO GRADING SYSTEM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(339, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 32)
        Label2.TabIndex = 1
        ' 
        ' GetStartedButton
        ' 
        GetStartedButton.Location = New Point(230, 154)
        GetStartedButton.Name = "GetStartedButton"
        GetStartedButton.Size = New Size(150, 46)
        GetStartedButton.TabIndex = 2
        GetStartedButton.Text = "Get Started"
        GetStartedButton.UseVisualStyleBackColor = True
        ' 
        ' WelcomeForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GetStartedButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "WelcomeForm"
        Text = "HomePage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GetStartedButton As Button

End Class
