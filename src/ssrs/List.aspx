<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="ssrs.List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="TreeViewItems" runat="server" OnSelectedNodeChanged="TreeViewItems_SelectedNodeChanged"></asp:TreeView>
        </div>
    </form>
</body>
</html>
