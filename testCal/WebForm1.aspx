<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="testCal.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
        <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" style="height: 29px" Text="Calculate" />
    
    </div>
        <asp:TextBox ID="txtOutput" runat="server"></asp:TextBox>
    </form>
</body>
</html>
