﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.B1.Location = New System.Drawing.Point(85, 55)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(75, 56)
        Me.B1.TabIndex = 0
        Me.B1.Text = "剪刀"
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.B2.Location = New System.Drawing.Point(185, 55)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(75, 56)
        Me.B2.TabIndex = 1
        Me.B2.Text = "石頭"
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Font = New System.Drawing.Font("新細明體", 13.0!)
        Me.B3.Location = New System.Drawing.Point(280, 55)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(75, 56)
        Me.B3.TabIndex = 2
        Me.B3.Text = "布"
        Me.B3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "你出："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "電腦出："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(177, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 262)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Name = "Form2"
        Me.Text = "剪刀石頭布"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents B3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
