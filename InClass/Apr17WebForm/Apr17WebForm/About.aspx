<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Apr17WebForm.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:Label ID="lblHeight" runat="server" Text="Height (cm)"></asp:Label>
    <asp:TextBox ID="txtHeight" runat="server"></asp:TextBox>
    <asp:Label ID="lblWeight" runat="server" Text="Weight (kg)"></asp:Label>
    <asp:TextBox ID="txtWeight" runat="server"></asp:TextBox>
    <asp:Button ID="btnBMI" runat="server" Text="Cal BMI" onclick="btnBMI_Click"/>
    <asp:Label ID="lblResult" runat="server" Text="result here"></asp:Label>

</asp:Content>
