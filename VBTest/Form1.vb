Imports System.IO
Imports System.Reflection.Metadata
Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet
Imports System
Imports System.Runtime.CompilerServices


Public Class Form1
    Private saveFileDialog1 As New SaveFileDialog()
    Dim id As Integer
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id = 0
        lstvData.FullRowSelect = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim x As MyItem
        'i++   -->   i = i + 1
        Dim description As String = txtDescription.Text
        id = id + 1
        Dim Price As Random = New Random()

        x = New MyItem(id, description, Math.Round(Price.NextDouble() * 1000, 2))
        lstItems.Items.Add(x.ToString())

        'ListView -- ListViewItems -- SubItems

        For i = 1 To 100
            Dim row As ListViewItem = New ListViewItem(x.Id)
            row.SubItems.Add(x.Description)
            row.SubItems.Add(x.Price)
            lstvData.Items.Add(row)
            x.Id = x.Id + 1
            x.Price = Math.Round(Price.NextDouble() * 1000, 2)

        Next
        UpdateLabel()
        UpdateTotal()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstvData.SelectedItems.Count = 0 Then
            Return
        End If
        For Each item As ListViewItem In lstvData.SelectedItems
            lstvData.Items.Remove(item)
        Next
        UpdateLabel()
        UpdateTotal()
    End Sub

    Sub UpdateLabel()
        lblCount.Text = lstvData.Items.Count
    End Sub
    Sub UpdateTotal()
        Dim Total As Decimal = 0
        For Each item As ListViewItem In lstvData.Items
            Total = Total + Decimal.Parse(item.SubItems(2).Text)
        Next
        LblTotal.Text = Total
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString())
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        saveFileDialog1.Filter = "Libro de Excel |*.xlsx"
        saveFileDialog1.Title = "EXCEL DOCUMENT"

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog1.FileName
            Dim spreadsheetDocument As SpreadsheetDocument = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook)

            ' Add a WorkbookPart to the document.
            Dim workbookpart As WorkbookPart = spreadsheetDocument.AddWorkbookPart
            workbookpart.Workbook = New Workbook

            ' Add a WorksheetPart to the WorkbookPart.
            Dim worksheetPart As WorksheetPart = workbookpart.AddNewPart(Of WorksheetPart)()
            worksheetPart.Worksheet = New Worksheet(New SheetData())

            ' Add Sheets to the Workbook.
            Dim sheets As Sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(Of Sheets)(New Sheets())

            ' Append a new worksheet and associate it with the workbook.
            Dim sheet As Sheet = New Sheet
            sheet.Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart)
            sheet.SheetId = 1
            sheet.Name = "Hoja de calculo "

            sheets.Append(sheet)

            Dim sheetData As SheetData = worksheetPart.Worksheet.Elements(Of SheetData)().First()

            ' Add the column headers.
            Dim headerRow As Row = New Row()
            headerRow.Append(New Cell() With {.CellReference = "A1", .DataType = CellValues.String, .CellValue = New CellValue("ID")})
            headerRow.Append(New Cell() With {.CellReference = "B1", .DataType = CellValues.String, .CellValue = New CellValue("Description")})
            headerRow.Append(New Cell() With {.CellReference = "C1", .DataType = CellValues.String, .CellValue = New CellValue("Price")})
            sheetData.Append(headerRow)

            ' Add the data rows.
            For Each item As ListViewItem In lstvData.Items
                Dim dataRow As Row = New Row()
                dataRow.Append(New Cell() With {.CellReference = "A" & (sheetData.Elements(Of Row)().Count + 2), .DataType = CellValues.String, .CellValue = New CellValue(item.SubItems(0).Text)})
                dataRow.Append(New Cell() With {.CellReference = "B" & (sheetData.Elements(Of Row)().Count + 2), .DataType = CellValues.String, .CellValue = New CellValue(item.SubItems(1).Text)})
                dataRow.Append(New Cell() With {.CellReference = "C" & (sheetData.Elements(Of Row)().Count + 2), .DataType = CellValues.String, .CellValue = New CellValue(item.SubItems(2).Text)})
                sheetData.Append(dataRow)
            Next

            workbookpart.Workbook.Save()

            ' Dispose the document.
            spreadsheetDocument.Dispose()
        End If
    End Sub






End Class
