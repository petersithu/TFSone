<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestBLLgridview.aspx.cs" Inherits="WebApplication1.TestBLLgridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" OnDataBound="GridView1_DataBound" OnRowCreated="GridView1_RowCreated" OnRowDataBound="GridView1_RowDataBound">
        </asp:GridView>
    </form>
</body>
</html>
