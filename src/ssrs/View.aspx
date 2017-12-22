<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="ssrs.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position: absolute; top: 0px; left: 0px; width: 99%; height: 99%;">
        <iframe runat="server" id="iFrameReport" name="iFrameReport" frameBorder="0" style="position: absolute; top: 5px; left: 5px; width: 100%; height: 100%;"></iframe>
    </div>
    </form>
</body>
</html>
