<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestGridView.aspx.cs" Inherits="WebApplication1.TestGridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" OnRowCreated="GridView1_RowCreated">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
