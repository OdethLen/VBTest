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
        btnExcel = New Button()
        btnRemove = New Button()
        btnSave = New Button()
        txtDescription = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lstvData = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        lstItems = New ListBox()
        LblTotal = New Label()
        lblCount = New Label()
        SuspendLayout()
        ' 
        ' btnExcel
        ' 
        btnExcel.Font = New Font("Segoe UI", 15F)
        btnExcel.Location = New Point(602, 54)
        btnExcel.Name = "btnExcel"
        btnExcel.Size = New Size(139, 38)
        btnExcel.TabIndex = 13
        btnExcel.Text = "Excel"
        btnExcel.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Segoe UI", 15F)
        btnRemove.Location = New Point(429, 54)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(139, 38)
        btnRemove.TabIndex = 12
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 15F)
        btnSave.Location = New Point(244, 54)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(139, 38)
        btnSave.TabIndex = 11
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New Font("Segoe UI", 15F)
        txtDescription.Location = New Point(29, 54)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(164, 34)
        txtDescription.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(-132, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 28)
        Label1.TabIndex = 9
        Label1.Text = "Description"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(29, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 28)
        Label2.TabIndex = 14
        Label2.Text = "Description"
        ' 
        ' lstvData
        ' 
        lstvData.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3})
        lstvData.Font = New Font("Segoe UI", 15F)
        lstvData.Location = New Point(291, 129)
        lstvData.Name = "lstvData"
        lstvData.Size = New Size(421, 175)
        lstvData.TabIndex = 16
        lstvData.UseCompatibleStateImageBehavior = False
        lstvData.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "DESCRIPTION"
        ColumnHeader2.Width = 200
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "PRICE"
        ColumnHeader3.Width = 120
        ' 
        ' lstItems
        ' 
        lstItems.Font = New Font("Segoe UI", 15F)
        lstItems.FormattingEnabled = True
        lstItems.ItemHeight = 28
        lstItems.Location = New Point(29, 132)
        lstItems.Name = "lstItems"
        lstItems.Size = New Size(214, 172)
        lstItems.TabIndex = 15
        ' 
        ' LblTotal
        ' 
        LblTotal.AutoSize = True
        LblTotal.Font = New Font("Segoe UI", 15F)
        LblTotal.Location = New Point(544, 318)
        LblTotal.Name = "LblTotal"
        LblTotal.Size = New Size(0, 28)
        LblTotal.TabIndex = 18
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Font = New Font("Segoe UI", 15F)
        lblCount.Location = New Point(329, 318)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(0, 28)
        lblCount.TabIndex = 17
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(777, 369)
        Controls.Add(LblTotal)
        Controls.Add(lblCount)
        Controls.Add(lstvData)
        Controls.Add(lstItems)
        Controls.Add(Label2)
        Controls.Add(btnExcel)
        Controls.Add(btnRemove)
        Controls.Add(btnSave)
        Controls.Add(txtDescription)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExcel As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstvData As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents lstItems As ListBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents lblCount As Label

End Class
