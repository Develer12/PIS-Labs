<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<%-- Part 1 --%>

    <div class="jumbotron">
            <input id="InputReset" type="reset" value="reset" onserverclick="Serv_Click" runat="server"/>
            <input id="InputButton" type="button" value="button" onserverclick="Serv_Click" runat="server"/>
            <input id="InputSubmit" type="submit" value="submit" onserverclick="Serv_Click" runat="server"/>
            <input id="InputFile" type="file" runat="server"/>
            <input id="InputText" type="text" value="reset" onserverchange="Serv_Change" onserverclick="Serv_Click" runat="server"/>
            <input id="InputPass" type="password" value="reset" onserverchange="Serv_Change" runat="server"/>
            <input id="InputCheck" type="checkbox" value="reset" onserverchange="Serv_Change" runat="server"/>
            <input id="InputRadio" type="radio" value="radio" onserverchange="Serv_Change" runat="server"/>
            <select id="Select">
                <option>da</option>
                <option>net</option>
            </select>
            <br />
            <asp:Table id="Table1" runat="server" style="width: 100%;">

            </asp:Table>
    </div>

<%-- Part 2 --%>
    <div class="jumbotron">
        <asp:TextBox class="lead" ID="TextBoxV" runat="server" ValidationGroup="vg1">Text</asp:TextBox>
        <asp:DropDownList class="lead" ID="DropDownListV" runat="server" ValidationGroup="vg1">
        </asp:DropDownList><br />
        <asp:Button class="lead" ID="ButtonV" runat ="server" Text="Button" ValidationGroup="vg1"/><br />
       
        <asp:RequiredFieldValidator ID="V1" runat="server" ErrorMessage="ValidatorERROR1" ControlToValidate="DropDownListV" ValidationGroup="vg1"> 
            Не выбрано значение в dropdown
        </asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="V2" runat="server" ErrorMessage="ValidatorERROR2" ControlToValidate="TextBoxV" ValidationGroup="vg1"> 
            Не введено значение в textbox
        </asp:RequiredFieldValidator>
    </div>

    <div class="jumbotron">
        <asp:TextBox class="lead" ID="TextBoxVR1" runat="server" ValidationGroup="vrg1">NUM</asp:TextBox>
        <asp:TextBox class="lead" ID="TextBoxVR2" runat="server" ValidationGroup="vrg1">DATE</asp:TextBox>
        <asp:Button class="lead" ID="ButtonVR" runat ="server" Text="Button" ValidationGroup="vrg1"/><br />
       
        <asp:RangeValidator ID="RV1" runat="server" ErrorMessage="ValidatorERROR1" ControlToValidate="TextBoxVR1" ValidationGroup="vrg1" Type="Integer" MaximumValue="200" MinimumValue="100"> 
            Wrong int range
        </asp:RangeValidator>
        <asp:RangeValidator ID="RV2" runat="server" ErrorMessage="ValidatorERROR2" ControlToValidate="TextBoxVR2" ValidationGroup="vrg1" Type="Date" MaximumValue="31.12.2011" MinimumValue="01.01.2011"> 
            Wrong date range
        </asp:RangeValidator>
    </div>

    <div class="jumbotron">
        <asp:TextBox class="lead" ID="TextBoxVC1" runat="server" ValidationGroup="vcg1">DATE</asp:TextBox>
        <asp:TextBox class="lead" ID="TextBoxVC2" runat="server" ValidationGroup="vcg1">DATE</asp:TextBox>
        <asp:Button class="lead" ID="Button1" runat ="server" Text="Button" ValidationGroup="vcg1"/><br />
       
        <asp:CompareValidator  ID="CompareValidator1" runat="server" ErrorMessage="ValidatorERROR2" ControlToValidate="TextBoxVC1" ControlToCompare="TextBoxVC2" ValidationGroup="vcg1" Type="Date" Operator="LessThan"> 
            Wrong date
        </asp:CompareValidator>
    </div>

    <div class="jumbotron">
        <asp:TextBox class="lead" ID="TextBoxVE1" runat="server" ValidationGroup="veg1">E-MAIL</asp:TextBox>
        <asp:Button class="lead" ID="Button2" runat ="server" Text="Button" ValidationGroup="veg1"/><br />
       
        <asp:RegularExpressionValidator  ID="RegularExpressionValidator1" runat="server" ErrorMessage="ValidatorERROR2" ControlToValidate="TextBoxVE1" ValidationGroup="veg1" ValidationExpression="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"> 
            Isn't e-mail
        </asp:RegularExpressionValidator>
    </div>

    <div class="jumbotron">
        <asp:TextBox class="lead" ID="TextBoxCV1" runat="server" ValidationGroup="cvg1"></asp:TextBox>
        <asp:Button class="lead" ID="Button3" runat ="server" Text="Button" ValidationGroup="cvg1"/><br />
       
        <asp:CustomValidator  ID="CustomValidator1" runat="server" ErrorMessage="ValidatorERROR2" ControlToValidate="TextBoxCV1" ValidationGroup="cvg1" ClientValidationFunction="clH" ServerValidation="servH"> 
            Not ordinary num
        </asp:CustomValidator>
        <script type="text/javascript">
            function clH(c, a) {
                let val = Number(a.Value);

                let nod = 0;
                let count = 1;

                for (let j = 1; j <= val; j++)
                {
                    if (val % j == 0) {
                        if (Math.floor(val / j) != 1 || Math.floor(val / j) != val) {
                            nod++;
                        }
                    }

                    if (nod > 2) {
                        count--;
                        break;
                    }
                }
                a.IsValid = (count == 1);
            }
        </script>
    </div>

    <div class="jumbotron">
        <asp:TextBox class="lead" ID="TextBox1" runat="server" ValidationGroup="vsg1">Фамилия</asp:TextBox>
        <asp:TextBox class="lead" ID="TextBox2" runat="server" ValidationGroup="vsg1">Имя</asp:TextBox>
        <asp:TextBox class="lead" ID="TextBox3" runat="server" ValidationGroup="vsg1">Отчество</asp:TextBox>
        <asp:TextBox class="lead" ID="TextBox4" runat="server" ValidationGroup="vsg1">Дата рождения</asp:TextBox>
        <asp:TextBox class="lead" ID="TextBox5" runat="server" ValidationGroup="vsg1">E-MAIL</asp:TextBox>
        <asp:TextBox class="lead" ID="TextBox6" runat="server" ValidationGroup="vsg1">Сумма</asp:TextBox>
        <asp:TextBox class="lead" ID="TextBox7" runat="server" ValidationGroup="vsg1">Пароль</asp:TextBox>

        <asp:Button class="lead" ID="Button4" runat ="server" Text="Button" ValidationGroup="vsg1"/><br />
       
        <asp:ValidationSummary  ID="ValidationSummary1" runat="server" ErrorMessage="ValidatorERROR2" ValidationGroup="vsg1" />

        <asp:RegularExpressionValidator  ID="RegularExpressionValidator2" runat="server" ErrorMessage="ValidatorERROR2" ControlToValidate="TextBox5" ValidationGroup="vsg1" ValidationExpression="^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"> 
            Isn't e-mail
        </asp:RegularExpressionValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="ValidatorERROR1" ControlToValidate="TextBox6" ValidationGroup="vsg1" Type="Integer" MaximumValue="2000" MinimumValue="1000"> 
            Wrong sum range
        </asp:RangeValidator>
        <asp:RegularExpressionValidator  ID="RegularExpressionValidator3" runat="server" ErrorMessage="ValidatorERROR2" ControlToValidate="TextBox1" ValidationGroup="vsg1" ValidationExpression="/[a-zA-Z0-9А-Яа-я()]/u"> 
            Non russian
        </asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator  ID="RegularExpressionValidator4" runat="server" ErrorMessage="ValidatorERROR2" ControlToValidate="TextBox2" ValidationGroup="vsg1" ValidationExpression="/[a-zA-Z0-9А-Яа-я()]/u"> 
            Non russian
        </asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator  ID="RegularExpressionValidator5" runat="server" ErrorMessage="ValidatorERROR2" ControlToValidate="TextBox3" ValidationGroup="vsg1" ValidationExpression="/[a-zA-Z0-9А-Яа-я()]/u"> 
            Non russian
        </asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator  ID="RegularExpressionValidator6" runat="server" ErrorMessage="ValidatorERROR2" ControlToValidate="TextBox7" ValidationGroup="vsg1" ValidationExpression="^[\s\S]{8,}$"> 
            Non valid password
        </asp:RegularExpressionValidator>
        <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="ValidatorERROR2" ControlToValidate="TextBox4" ValidationGroup="vrg1" Type="Date"> 
            Wrong date
        </asp:RangeValidator>
    </div>
<%-- Part 3 --%>
</asp:Content>
