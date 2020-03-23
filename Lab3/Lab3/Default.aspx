<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<%-- Part 1 --%>

    <div class="jumbotron">
            <h3>Part 1</h3>
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
<h3>Part 1</h3>

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
<h3>Part 1</h3>

    <div class="jumbotron">
        <asp:MultiView ID="MV1" runat="server" ActiveViewIndex="0">
            <asp:View ID="MV1v1" runat="server">
                View 1
                <asp:TextBox class="lead" ID="MV1v1T" runat="server">Da</asp:TextBox>
                <br />
                <asp:Button class="lead" ID="ButtMV1" OnClick="ButtMV3_Click" runat ="server" Text="Button"/>
                <br />

                    <asp:Wizard ID="Wizard1" runat="server" Width="500px"
                         OnNextButtonClick="Wizard1_OnNextButtonClick">
                        <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="Black" />
                        <SideBarStyle BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
                        <StepStyle BorderWidth="0px" ForeColor="Black" />
                        <WizardSteps>
                            <asp:WizardStep ID="WizardStep1" runat="server" Title="TextBox">
                                <div style="background-image: url(Img/back.png)">
                                <table class="bgwizard" style="min-width: 500px; min-height: 500px;">
                                    <tr>
                                        <td>Textbox</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="WizardTextbox"></asp:TextBox></td>
                                    </tr>
                                </table>
                                <</div>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="RadioButtonList">
                                <table>
                                    <tr>
                                        <td>RadioButtonList</td>
                                        <td>
                                            <asp:RadioButtonList runat="server" ID="WizardRadioButtonList">
                                                <asp:ListItem Selected="True" Text="Variant 1" Value="Variant 1" />
                                                <asp:ListItem Selected="False" Text="Variant 2" Value="Variant 2" />
                                                <asp:ListItem Selected="False" Text="Variant 3" Value="Variant 3" />
                                                <asp:ListItem Selected="False" Text="Variant 4" Value="Variant 4" />
                                                <asp:ListItem Selected="False" Text="Variant 5" Value="Variant 5" />
                                            </asp:RadioButtonList></td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="CheckBoxList">
                                <table>
                                    <tr>
                                        <td>CheckBoxList</td>
                                        <td>
                                            <asp:CheckBoxList runat="server" ID="WizardCheckBoxList">
                                                <asp:ListItem Selected="True" Text="Variant 1" Value="Variant 1" />
                                                <asp:ListItem Selected="False" Text="Variant 2" Value="Variant 2" />
                                                <asp:ListItem Selected="False" Text="Variant 3" Value="Variant 3" />
                                                <asp:ListItem Selected="False" Text="Variant 4" Value="Variant 4" />
                                                <asp:ListItem Selected="False" Text="Variant 5" Value="Variant 5" />
                                            </asp:CheckBoxList></td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="ListBox">
                                <table>
                                    <tr>
                                        <td>ListBox</td>
                                        <td>
                                            <asp:ListBox runat="server" ID="WizardListBox">
                                                <asp:ListItem Text="Variant 1" Value="Variant 1" />
                                                <asp:ListItem Text="Variant 2" Value="Variant 2" />
                                                <asp:ListItem Text="Variant 3" Value="Variant 3" />
                                                <asp:ListItem Text="Variant 4" Value="Variant 4" />
                                                <asp:ListItem Text="Variant 5" Value="Variant 5" />
                                            </asp:ListBox></td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="Calendar">
                                <table>
                                    <tr>
                                        <td>ListBox</td>
                                        <td>
                                            <asp:Calendar runat="server" ID="WizardCalendar"></asp:Calendar>
                                        </td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="Calendars">
                                <table>
                                    <tr>
                                        <td>ListBox</td>
                                        <td>
                                            <asp:Calendar runat="server" ID="WizardCalendars" OnDayRender="Calendars_DayRender" OnSelectionChanged="WizardCalendars_OnSelectionChanged"></asp:Calendar>
                                        </td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="Result">
                                <asp:Label runat="server" ID="WizardResult"></asp:Label>
                            </asp:WizardStep>


                        </WizardSteps>
                        <SideBarStyle VerticalAlign="Top" />

                    </asp:Wizard>
            </asp:View>
            <asp:View ID="MV1v2" runat="server">
                View 2
                <asp:TextBox class="lead" ID="MV1v2T" runat="server">Da</asp:TextBox>
                <br />
                <asp:Button class="lead" ID="ButtMV2" OnClick="ButtMV3_Click" runat ="server" Text="Button"/>
            </asp:View>
            <asp:View ID="MV1v3" runat="server">
                View 3
                <asp:TextBox class="lead" ID="MV1v3T" runat="server">Da</asp:TextBox>
                <br />
                <asp:Button class="lead" ID="ButtMV3" OnClick="ButtMV3_Click" runat ="server" Text="Button"/>
            </asp:View>
        </asp:MultiView>
    </div>

    <div class="jumbotron">
        <asp:AdRotator ID="adR1" runat="server" AdvertisementFile="~/App_Data/AdR1.xml" Height="100%" Width="100%" />
        <asp:Button class="lead" ID="AdButt" OnClick="AdButt_Click" runat ="server" Text="-> b1"/>
    </div>

    <div class="jumbotron">
        <asp:TreeView ID="TreeView" runat="server" ShowLines="True" OnSelectedNodeChanged="TreeView_OnSelectedNodeChanged">
                    <Nodes>
                        <asp:TreeNode Expanded="True" Text="1" Value="1" ShowCheckBox="False">
                            <asp:TreeNode Text="1.1" Value="1.1">
                                <asp:TreeNode ShowCheckBox="True" Text="1.1.1" Value="1.1.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="1.1.2" Value="1.1.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="1.1.3" Value="1.1.3"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode ImageUrl="../Images/mango.jpg" Value="1.2">
                                <asp:TreeNode ShowCheckBox="True" Text="1.2.1" Value="1.2.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="1.2.2" Value="1.2.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="1.2.3" Value="1.2.3"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="1.3" Value="1.3">
                                <asp:TreeNode ShowCheckBox="True" Text="1.3.1" Value="1.3.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="1.3.2" Value="1.3.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="1.3.3" Value="1.3.3"></asp:TreeNode>
                            </asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Expanded="True" Text="2" Value="2" ShowCheckBox="False">
                            <asp:TreeNode ShowCheckBox="True" Text="2.1" Value="2.1">
                                <asp:TreeNode ShowCheckBox="True" Text="2.1.1" Value="2.1.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="2.1.2" Value="2.1.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="2.1.3" Value="2.1.3"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode ShowCheckBox="True" Text="2.2" Value="2.2">
                                <asp:TreeNode ShowCheckBox="True" Text="2.2.1" Value="2.2.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="2.2.2" Value="2.2.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="2.2.3" Value="2.2.3"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode ShowCheckBox="True" Text="2.3" Value="2.3" ImageUrl="Img/back.png">
                                <asp:TreeNode ShowCheckBox="True" Text="2.3.1" Value="2.3.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="2.3.2" Value="2.3.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="2.3.3" Value="2.3.3"></asp:TreeNode>
                            </asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Expanded="True" Text="3" ToolTip="Узел 3" Value="3" ShowCheckBox="False">
                            <asp:TreeNode Text="3.1" ToolTip="Узел 3.1" Value="3.1">
                                <asp:TreeNode ShowCheckBox="True" Text="3.1.1" Value="3.1.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="3.1.2" Value="3.1.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="3.1.3" Value="3.1.3"></asp:TreeNode>
                                </asp:TreeNode>
                            <asp:TreeNode Text="3.2" ToolTip="Узел 3.2" Value="3.2">
                                <asp:TreeNode ShowCheckBox="True" Text="3.2.1" Value="3.2.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="3.2.2" Value="3.2.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="3.2.3" Value="3.2.3"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="3.3" ToolTip="Узел 3.3" Value="3.3">
                                <asp:TreeNode ShowCheckBox="True" Text="3.2.1" Value="3.2.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="3.2.2" Value="3.2.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="3.2.3" Value="3.2.3"></asp:TreeNode>
                            </asp:TreeNode>
                        </asp:TreeNode>
                    </Nodes>
                </asp:TreeView>
                <asp:Button runat="server" ID="TreeViewButton" OnClick="TreeViewButton_OnClick" Text="save"/>
                <asp:Label runat="server" ID="TreeViewResult"></asp:Label>

    </div>

    <div class="jumbotron">
        <asp:Menu runat="server" ID="Menu" CssClass="menuclass" StaticDisplayLevels="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#7C6F57" OnMenuItemClick="Menu_itemClick">
                    <Items>
                        <asp:MenuItem Text="Var 1">
                            <asp:MenuItem Text="Var 1.1" Value="Var 1.1">
                                    <asp:MenuItem Text="1.1.1" Value="1.1.1"></asp:MenuItem>
                                    <asp:MenuItem Text="1.1.2" Value="1.1.2"></asp:MenuItem>
                                    <asp:MenuItem Text="1.1.3" Value="1.1.3"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="Var 1.2" Value="Var 1.2">
                                <asp:MenuItem Text="1.2.1" Value="1.2.1"></asp:MenuItem>
                                <asp:MenuItem Text="1.2.2" Value="1.2.2"></asp:MenuItem>
                                <asp:MenuItem Text="1.2.3" Value="1.2.3"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="Var 1.3" Value="Var 1.3"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="Var 2">
                            <asp:MenuItem Text="Var 2.1" Value="Var 2.1">
                                <asp:MenuItem Text="2.1.1" Value="2.1.1"></asp:MenuItem>
                                <asp:MenuItem Text="2.1.2" Value="2.1.2"></asp:MenuItem>
                                <asp:MenuItem Text="2.1.3" Value="2.1.3"></asp:MenuItem>
                            </asp:MenuItem>         
                            <asp:MenuItem Text="Var 2.2" Value="Var 2.2">
                                <asp:MenuItem Text="2.2.1" Value="2.2.1"></asp:MenuItem>
                                <asp:MenuItem Text="2.2.2" Value="2.2.2"></asp:MenuItem>
                                <asp:MenuItem Text="2.2.3" Value="2.2.3"></asp:MenuItem>
                            </asp:MenuItem>   
                        </asp:MenuItem>
                    </Items>
                </asp:Menu>
                <asp:Label runat="server" ID="MenuResult"></asp:Label>
    </div>

</asp:Content>
