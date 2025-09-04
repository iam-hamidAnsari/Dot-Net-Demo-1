<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Dot_Net_Demo_1.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="margin-left:30%;">Employee Management System</h2>
        </div>
        <div>

            <asp:Button ID="Button1" runat="server" Text="Add Emp" OnClick="Button1_Click" />

        </div>
        <div>



            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ClientIDMode="AutoID">
                <Columns>
                    <asp:TemplateField HeaderText="ID"> 
                        <ItemTemplate>
                            <asp:Label runat="server" ID="Label1" Text='<%#Eval("nid")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name"> 
                        <ItemTemplate>
                            <asp:Label runat="server"  ID="Label2" Text='<%#Eval("cname")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Salary"> 
                        <ItemTemplate>
                            <asp:Label runat="server"  ID="Label3" Text='<%#Eval("dsalary")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Age"> 
                        <ItemTemplate>
                            <asp:Label runat="server"  ID="Label4" Text='<%#Eval("nage")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>


        </div>
    </form>
</body>
</html>
