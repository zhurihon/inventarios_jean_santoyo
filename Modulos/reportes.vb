
Imports OfficeOpenXml
Imports OfficeOpenXml.Style
Imports System.Diagnostics
Imports System.IO

Module reportes


    Public Sub fexcel2(dat As DataSet, tipo As String)

        'fcarpetaSistema()




        Dim saveFileDialog As New SaveFileDialog()
        Dim filePath As String
        ' Configurar el diálogo
        saveFileDialog.Filter = "excel|*.XLSX|Reporte en excel|*.*"
        saveFileDialog.Title = "Guardar archivo"
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        ' Mostrar el diálogo y verificar si el usuario presionó "Guardar"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Obtener la ruta del archivo seleccionado
            filePath = saveFileDialog.FileName

            ' Escribir contenido al archivo
            Try
                'Dim contenido As String = "Es"
                'File.WriteAllText(filePath, contenido)

                'MessageBox.Show("Archivo guardado exitosamente en: " & filePath)
            Catch ex As Exception
                'MessageBox.Show("Error al guardar el archivo: " & ex.Message)
            End Try
        End If


        ' Establecer el contexto de la licencia de EPPlus
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        ' Obtener la ruta de la carpeta "reportes"


        Dim plantillaPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reporte.xlsx")

        ' Crear el archivo Excel a partir de la plantilla
        Using package As New ExcelPackage(New FileInfo(plantillaPath))
            Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets(0) ' Usar la primera hoja de la plantilla
            Dim dataTable As DataTable = dat.Tables(0)

            ' Llenar la hoja de cálculo con los datos del DataTable comenzando desde la fila 6
            Dim startRow As Integer = 5
            worksheet.Cells(startRow, 1).LoadFromDataTable(dataTable, True)

            ' Construir el nombre del archivo
            Dim fileName As String = tipo & " " & DateTime.Now.ToString("yyyy-MM-dd") & ".xlsx"
            'Dim filePath As String = Path.Combine(reportesPath, fileName)

            ' Guardar el archivo en la carpeta "reportes"
            package.SaveAs(New FileInfo(filePath))
            Process.Start(filePath)
        End Using
    End Sub

    Public Sub fexcelEXMAPLE(dat As DataSet, tipo As String)


        ' Establecer el contexto de la licencia de EPPlus
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        ' Obtener la ruta de la carpeta "reportes"
        Dim documentosPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim reportesPath As String = Path.Combine(documentosPath, "sistema de gestion", "reportes")

        ' Ruta de la plantilla en la raíz del programa
        Dim plantillaRaizPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reporte plantilla.xlsx")
        ' Ruta de la plantilla en la carpeta de reportes
        Dim plantillaPath As String = Path.Combine(reportesPath, "Reporte plantilla.xlsx")

        ' Verificar si la plantilla existe en la carpeta de reportes
        If Not File.Exists(plantillaPath) Then
            ' Si no existe, copiar la plantilla desde la raíz
            If File.Exists(plantillaRaizPath) Then
                File.Copy(plantillaRaizPath, plantillaPath)
            Else
                Throw New FileNotFoundException("La plantilla 'Reporte plantilla.xlsx' no se encontró en la raíz del programa.")
            End If
        End If

        ' Crear el archivo Excel a partir de la plantilla
        Using package As New ExcelPackage(New FileInfo(plantillaPath))
            Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets(0) ' Usar la primera hoja de la plantilla
            Dim dataTable As DataTable = dat.Tables(0)

            ' Llenar la hoja de cálculo con los datos del DataTable comenzando desde la fila 6
            Dim startRow As Integer = 5
            worksheet.Cells(startRow, 1).LoadFromDataTable(dataTable, True)

            ' Construir el nombre del archivo
            Dim fileName As String = "Reporte " & tipo & " " & DateTime.Now.ToString("yyyy-MM-dd") & ", " & DateTime.Now.ToString("hh-mm") & ".xlsx"
            Dim filePath As String = Path.Combine(reportesPath, fileName)

            ' Guardar el archivo en la carpeta "reportes"
            package.SaveAs(New FileInfo(filePath))
            Process.Start(filePath)
        End Using
    End Sub

    Public Function ExtraerDataGridViewADataSet(dgv As DataGridView) As DataSet
        ' Crear un nuevo DataSet
        Dim dataSet As New DataSet()
        ' Crear una nueva DataTable
        Dim dataTable As New DataTable("reporte")

        ' Agregar columnas al DataTable
        For Each column As DataGridViewColumn In dgv.Columns
            dataTable.Columns.Add(column.Name, GetType(String))
        Next

        ' Agregar filas al DataTable
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then ' Ignorar la fila nueva
                Dim dataRow As DataRow = dataTable.NewRow()
                For Each column As DataGridViewColumn In dgv.Columns
                    dataRow(column.Name) = row.Cells(column.Name).Value.ToString
                Next
                dataTable.Rows.Add(dataRow)
            End If
        Next

        ' Agregar el DataTable al DataSet
        dataSet.Tables.Add(dataTable)

        Return dataSet
    End Function



End Module
