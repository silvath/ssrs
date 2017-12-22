<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="ssrs.View" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=14.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="True" EnablePageMethods="True" EnableScriptGlobalization="true" EnableScriptLocalization="true"></asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer" runat="server" Width="100%" Height="100%" ProcessingMode="Remote" AsyncRendering="true" PromptAreaCollapsed="true" ShowPromptAreaButton="true" ShowBackButton="True" Font-Names="Verdana"  Font-Size="8pt" ></rsweb:ReportViewer>
        <div>
        </div>
    </form>
</body>
</html>
