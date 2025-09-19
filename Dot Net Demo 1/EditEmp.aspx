<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditEmp.aspx.cs" Inherits="Dot_Net_Demo_1.EditEmp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
      <H2 style="margin-left:30%;">Edit Emp</H2>
  </div>
  <DIV>

      Name :
      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      <BR />
      <BR />
      Age :
      <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
      <BR />
      <BR />
      Salary :
      <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
      <BR />
      <BR />
      <BR />
      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Edit Emp" />

  </DIV>
    </form>
</body>
</html>
