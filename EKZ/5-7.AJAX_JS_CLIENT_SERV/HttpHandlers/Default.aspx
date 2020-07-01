<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HttpHandlers.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
            <asp:Button ID="buttonGet" Text="Get" runat="server" Onclick="buttonGet_Click1"/>
            <input type="button" value="XmlHttpRequest" onclick="GetMul()" />
        </div>
        <div>
            <div>
                <label>parmA: </label>
                <asp:TextBox ID="parmA" runat="server" />
            </div>
            <div>
                <label>parmB: </label>
                <asp:TextBox ID="parmB" runat="server" />
            </div>
        </div>
         <hr />
        <div>
            <asp:Label ID="labelResult" runat="server">result: </asp:Label>
        </div>
    </form>
     <script type="text/javascript">
         function GetMul() {
             let num1 = document.getElementById("parmA");
             let num2 = document.getElementById("parmB");
             let result = document.getElementById('labelResult');

             let url = `http://localhost:52468/qwerty.post?parma=${num1.value}&parmb=${num2.value}`;

             function responseLoad() {
                 if (request.readyState == 4) {
                     var status = request.status;
                     if (status == 200) {
                         result.innerText = request.responseText
                     } else {
                         result.innerText = request.statusText;
                     }
                 }
             }

             let request = new XMLHttpRequest();
             request.open("POST", url, true);
             request.onload = responseLoad;
             request.send();
         }
    </script>
</body>
</html>
