<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" EnableEventValidation="false" Inherits="ConvertirPDF_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Image ID="Image1" runat="server" ImageUrl="http://www.developerji.com/App_Themes/Principal/Images/logo.png" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Button ID="btnExportasPDF" runat="server" Text="Exportar Página a PDF"
            OnClick="btnExportasPDF_Click" />
        <br />
        <br />
        Más ejemplos en: <a href="http://www.developerji.com/">http://www.developerji.com/</a>
        <br />
    </div>
    </form>
</body>
</html>
