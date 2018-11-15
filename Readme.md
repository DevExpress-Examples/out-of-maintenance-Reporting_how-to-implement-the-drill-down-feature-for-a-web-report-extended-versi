<!-- default file list -->
*Files to look at*:

* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to implement the drill-down feature for a web report: extended version


<p>This example is an extended version of the following solution: <a href="http://www.devexpress.com/Support/Center/CodeCentral/ViewExample.aspx?exampleId=E287"><u>How to implement the drill-down feature for XtraReports in a web application</u></a>.</p><p>The main improvement in this example is using the <a href="http://documentation.devexpress.com/#AspNet/CustomDocument8277"><u>ASPxCallbackPanel</u></a> to host the <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument5193"><u>ASPxDocumentViewer</u></a> control. As a result, the report content is being updated via the callbacks, with the benefits of avoiding the entire web page being regenerated and maintaining the position of the web browser window scrollbars.</p><p>Clicking the nodes in the master report calls the corresponding javascript event handler (a similar technique is described in the following example: <a href="http://www.devexpress.com/Support/Center/CodeCentral/ViewExample.aspx?exampleId=E1337"><u>How to use the ASPxPopupControl to implement a drill-down report</u></a>). This initiates the callback to the server via the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxCallbackPanelScriptsASPxClientCallbackPanel_PerformCallbacktopic"><u>ASPxClientCallbackPanel.PerformCallback</u></a> method. </p><p>The consequent updating of the report document is performed on the server within the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxCallbackPanelASPxCallbackPanel_Callbacktopic"><u>ASPxCallbackPanel.Callback</u></a> event handler. Once the callback is completed, the resulting report appears on the client.</p><br />


<br/>


