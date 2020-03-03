<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Button ID="GetButt" Text="Get" runat="server" width="67px" OnClick="GetButt_Click" />
        <asp:Button ID="PutButt" Text="Put" runat="server" width="67px" OnClick="PutButt_Click" />
        <asp:Button ID="PostButt" Text="Post" runat="server" width="67px" OnClick="PostButt_Click" />
    </div>
            <button width="67px" onclick="Senda()">Send</button>
        <script>
            function Senda(){
                let xhr = new XMLHttpRequest();
                xhr.open('POST', 'http://localhost:8092/yyy.ndy?a=1&b=3', true);
                xhr.send();
                xhr.onload = function() {
                    if (xhr.readyState != 4) return;
                    if (xhr.status != 200)
                        alert(xhr.status + ': ' + xhr.statusText);
                    else 
                        alert(xhr.responseText);
                }
            }
        </script>
</asp:Content>
