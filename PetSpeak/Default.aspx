<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PetSpeak._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">  

        <p>
                <a class="btn btn-default" onclick="GetPalindromePetList();return false;">Get Clinics</a>
        </p>
        <h1>Pets in the House</h1>
        <div id="divPets"> </div>
    </div>

</asp:Content>
