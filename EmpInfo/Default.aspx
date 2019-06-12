<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmpInfo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Employee Information</h2>
        </div>
        <p>
            &nbsp;</p>
        <p>
            Name:
            <asp:TextBox ID="TxtName" runat="server" OnTextChanged="TxtName_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Select Office:&nbsp; <asp:DropDownList ID="DropList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Pick City</asp:ListItem>
                <asp:ListItem>Toronto</asp:ListItem>
                <asp:ListItem>New York</asp:ListItem>
                <asp:ListItem>London</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
&nbsp;
            <asp:Label ID="LblResult" runat="server"></asp:Label>
        </p>
        <p>
            Department:</p>
        <p>
            <asp:RadioButton ID="RdoMarketing" runat="server" GroupName="Department" Text="Marketing" />
        </p>
        <p>
            <asp:RadioButton ID="RdoAccounting" runat="server" GroupName="Department" OnCheckedChanged="Radio_CheckedChanged" Text="Accounting" />
        </p>
        <p>
            <asp:RadioButton ID="RdoLegal" runat="server" GroupName="Department" OnCheckedChanged="RadioButton3_CheckedChanged" Text="Legal" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            Qualifications:</p>
        <p>
            <asp:CheckBox ID="ChkBABS" runat="server" Text="BA/BS" />
        </p>
        <p>
            <asp:CheckBox ID="ChkMA" runat="server" Text="MA" />
        </p>
        <p>
            <asp:CheckBox ID="ChkPHD" runat="server" Text="PHD" />
        </p>
        <p>
            <asp:Button ID="ButtonSend" runat="server" OnClick="ButtonSend_Click" Text="Send" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="LblFullResult" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
