<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Layer._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Label ID="lblUserName" runat="server" Text="UserName :"></asp:Label>
    <asp:TextBox ID="txtUName" runat="server"></asp:TextBox>
    <asp:Label ID="lblPassword" runat="server" Text="Password :"></asp:Label>
    <asp:TextBox ID="txtUserPass" runat="server"></asp:TextBox>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" 
        onrowdeleting="GridView1_RowDeleting" Width="485px">
    </asp:GridView>
    <asp:Button ID="btn_save" runat="server" onclick="btn_save_Click" Text="Save" />
    <asp:Button ID="btn_Del" runat="server" onclick="btn_Del_Click" Text="Delete" />
    <asp:TextBox ID="txt_oldName" runat="server"></asp:TextBox>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" 
        TypeName="Layer.BussinessLayer">
        <DeleteParameters>
            <asp:Parameter Name="uname" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="uname" Type="String" />
            <asp:Parameter Name="pass" Type="String" />
        </InsertParameters>
    </asp:ObjectDataSource>
</asp:Content>
