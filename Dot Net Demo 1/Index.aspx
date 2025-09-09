<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Dot_Net_Demo_1.Index" %>

<!DOCTYPE html>

<HTML XMLNS="http://www.w3.org/1999/xhtml">
<HEAD RUNAT="server">
    <TITLE></TITLE>
</HEAD>
<BODY>
    <FORM ID="form1" RUNAT="server">
        <DIV>
            <H2 STYLE="margin-left: 30%;">Employee Management System</H2>
        </DIV>
        <DIV>

            <asp:Button ID="Button1" runat="server" Text="Add Emp" OnClick="Button1_Click" />

        </DIV>
        <DIV>



            <%--<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ClientIDMode="AutoID">
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
            </asp:GridView>--%>


            <BR />
            &nbsp;<asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Employee Name"></asp:TextBox>
            &nbsp;

            <asp:Button ID="Button2" runat="server" Text="Fetch Emp" OnClick="Button2_Click" />




        &nbsp;

            <asp:Button ID="Button3" runat="server" Text="Clear" OnClick="Button3_Click" />




        </DIV>

        <div RUNAT ="server" id="err" VISIBLE="false">
                        <asp:Label ID="Label4" runat="server" style="color:red;">No Records Found For Given Name in Db!!</asp:Label>
        </div>
        <div RUNAT="server" id="EmpLbl" VISIBLE="false">
            <BR />
            <BR />
            Name :
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <BR />
            <BR />
            Age :
  <asp:Label ID="Label2" runat="server"></asp:Label>
            <BR />
            <BR />
            Salary :
  <asp:Label ID="Label3" runat="server"></asp:Label>
        </div>
    </FORM>
</BODY>
</HTML>
