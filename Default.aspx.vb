Imports System
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Xml.Linq

' include iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf
Imports System.Text
Imports System.IO

Partial Class ConvertirPDF_Default
    Inherits System.Web.UI.Page
    Private dt As New DataTable()


    Protected Sub btnExportasPDF_Click(sender As Object, e As EventArgs) Handles btnExportasPDF.Click
        Response.ContentType = "application/pdf"
        Response.AddHeader("content-disposition", "attachment;filename=TestPage.pdf")
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Dim sw As New StringWriter()
        Dim hw As New HtmlTextWriter(sw)
        Me.Page.RenderControl(hw)
        Dim sr As New StringReader(sw.ToString())
        Dim pdfDoc As New Document(PageSize.A4, 10.0F, 10.0F, 100.0F, 0.0F)
        Dim htmlparser As New HTMLWorker(pdfDoc)
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream)
        pdfDoc.Open()
        htmlparser.Parse(sr)
        pdfDoc.Close()
        Response.Write(pdfDoc)
        Response.[End]()
    End Sub

    Protected Sub Page_Load1(sender As Object, e As EventArgs) Handles Me.Load
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Nombre", GetType(String))
        dt.Columns.Add("Dirección", GetType(String))
        dt.Columns.Add("Fecha", GetType(DateTime))

        '
        ' Here we add five DataRows.
        '
        dt.Rows.Add(25, "José", "México", DateTime.Now)
        dt.Rows.Add(50, "DeveloperJI", "Distrito Federal", DateTime.Now)
        dt.Rows.Add(10, "Juan", "Morelos", DateTime.Now)
        dt.Rows.Add(21, "Fernanda", "Aguascalientes", DateTime.Now)
        dt.Rows.Add(100, "Alejandra", "Hidalgo", DateTime.Now)

        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub
End Class
