<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PetSpeak._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">  

        
        <h1>Pets in the House</h1>
        <div id="divPets"> </div>

        <p>
            <br/><br/>
            <a class="btn btn-default" onclick="ShowPetList();return false;">Refresh Pets</a>
        </p>

    </div>

    <script>
        ShowPetList();
    </script>

</asp:Content>


