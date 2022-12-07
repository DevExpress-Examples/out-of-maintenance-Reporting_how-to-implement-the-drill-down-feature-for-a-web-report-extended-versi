﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v15.1.Web, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxcp" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        <dxcp:ASPxCallbackPanel ID="ASPxCallbackPanel1" ClientInstanceName="ASPxCallbackPanel1" runat="server" Width="800px" 
            oncallback="ASPxCallbackPanel1_Callback">
            <PanelCollection>
                <dxp:PanelContent runat="server">
                    <dxxr:ASPxDocumentViewer ID="DocumentViewer1" runat="server" ReportTypeName="XtraReport1" >
                    </dxxr:ASPxDocumentViewer>
                </dxp:PanelContent>
            </PanelCollection>
        </dxcp:ASPxCallbackPanel>
        </center>
    </div>
    </form>
</body>
</html>
