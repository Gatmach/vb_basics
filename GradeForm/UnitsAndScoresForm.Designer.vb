<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitsAndScoresForm
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
        CalculateGradeButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' CalculateGradeButton
        ' 
        CalculateGradeButton.Location = New Point(258, 306)
        CalculateGradeButton.Name = "CalculateGradeButton"
        CalculateGradeButton.Size = New Size(218, 46)
        CalculateGradeButton.TabIndex = 11
        CalculateGradeButton.Text = "Compute Grade"
        CalculateGradeButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(157, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(363, 32)
        Label1.TabIndex = 12
        Label1.Text = "WELCOME TO GRADING SYSTEM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(78, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 32)
        Label2.TabIndex = 13
        Label2.Text = "Subjects"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(258, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 32)
        Label3.TabIndex = 14
        Label3.Text = "Scores"
        ' 
        ' UnitsAndScoresForm
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CalculateGradeButton)
        Name = "UnitsAndScoresForm"
        Text = "UnitsAndScoresForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CalculateGradeButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
