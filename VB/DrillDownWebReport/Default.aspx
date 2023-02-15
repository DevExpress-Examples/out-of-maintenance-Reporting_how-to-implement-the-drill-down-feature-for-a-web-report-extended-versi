<%@ Page Title="Home Page" Language="vb" AutoEventWireup="true"
    CodeBehind="Default.aspx.vb" Inherits="DrillDownWebReport._Default" %>

<%@ Register assembly="DevExpress.XtraReports.v16.1.Web, Version=16.1.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
    namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>

<!DOCTYPE html">

<html xmlns="http://www.w3.org/1999/xhtml" >
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxWebDocumentViewer ID="documentViewer" runat="server" ReportSourceId="DrillDownWebReport.XtraReport1">
        </dx:ASPxWebDocumentViewer>
    </div>
    </form>
</body>
</html>