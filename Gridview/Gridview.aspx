<%@ Page Language="C#" AutoEventWireup="true" Inherits="Gridview" Codebehind="Gridview.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                <table border="1" cellpadding="0" cellspacing="0" style="border-collapse: collapse">
<tr>
    <td style="width: 150px">
        PKPKPKPKPK:<br />
        <asp:TextBox ID="txtSearchPKPKPKPKPK" runat="server" Width="140" />
    </td>
    <td style="width: 100px">
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="Search" />
    </td>
        <td style="width: 100px">
        <asp:Button ID="btnShowAll" runat="server" Text="Show all" OnClick="Showall" />
    </td>
</tr>
</table>
    <asp:GridView ID="gvTTTTT" runat="server" AutoGenerateColumns="false" DataKeyNames="PKPKPKPKPK"
OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
OnRowUpdating="OnRowUpdating">
<Columns>
    <asp:TemplateField HeaderText="PKPKPKPKPK" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblPKPKPKPKPK" runat="server" Text='<%# Eval("PKPKPKPKPK") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtPKPKPKPKPK" runat="server" Enabled="False" Text='<%# Eval("PKPKPKPKPK") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="FFFF1" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFF1" runat="server" Text='<%# Eval("FFFF1") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFF1" runat="server" Enabled="False" Text='<%# Eval("FFFF1") %>'></asp:TextBox>
        </EditItemTemplate>
   </asp:TemplateField>
   <asp:TemplateField HeaderText="FFFF2" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFF2" runat="server" Text='<%# Eval("FFFF2") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFF2" runat="server" Enabled="False" Text='<%# Eval("FFFF2") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
        <asp:TemplateField HeaderText="FFFF3" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFF3" runat="server" Text='<%# Eval("FFFF3") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFF3" runat="server" Enabled="False" Text='<%# Eval("FFFF3") %>'></asp:TextBox>
        </EditItemTemplate>
   </asp:TemplateField>
   <asp:TemplateField HeaderText="FFFF4" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFF4" runat="server" Text='<%# Eval("FFFF4") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFF4" runat="server" Enabled="False" Text='<%# Eval("FFFF4") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="FFFF5" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFF5" runat="server" Text='<%# Eval("FFFF5") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFF5" runat="server" Enabled="False" Text='<%# Eval("FFFF5") %>'></asp:TextBox>
        </EditItemTemplate>
   </asp:TemplateField>
   <asp:TemplateField HeaderText="FFFF6" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFF6" runat="server" Text='<%# Eval("FFFF6") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFF6" runat="server" Enabled="False" Text='<%# Eval("FFFF6") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
        <asp:TemplateField HeaderText="FFFF7" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFF7" runat="server" Text='<%# Eval("FFFF7") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFF7" runat="server" Enabled="False" Text='<%# Eval("FFFF7") %>'></asp:TextBox>
        </EditItemTemplate>
   </asp:TemplateField>
   <asp:TemplateField HeaderText="FFFF8" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFF8" runat="server" Text='<%# Eval("FFFF8") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFF8" runat="server" Enabled="False" Text='<%# Eval("FFFF8") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="FFFF9" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFF9" runat="server" Text='<%# Eval("FFFF9") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFF9" runat="server" Enabled="False" Text='<%# Eval("FFFF9") %>'></asp:TextBox>
        </EditItemTemplate>
   </asp:TemplateField>
   <asp:TemplateField HeaderText="FFFFA" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFFA" runat="server" Text='<%# Eval("FFFFA") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFFA" runat="server" Enabled="False" Text='<%# Eval("FFFFA") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
        <asp:TemplateField HeaderText="FFFFB" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFFB" runat="server" Text='<%# Eval("FFFFB") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFFB" runat="server" Enabled="False" Text='<%# Eval("FFFFB") %>'></asp:TextBox>
        </EditItemTemplate>
   </asp:TemplateField>
   <asp:TemplateField HeaderText="FFFFC" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFFC" runat="server" Text='<%# Eval("FFFFC") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFFC" runat="server" Enabled="False" Text='<%# Eval("FFFFC") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="FFFFD" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFFD" runat="server" Text='<%# Eval("FFFFD") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFFD" runat="server" Enabled="False" Text='<%# Eval("FFFFD") %>'></asp:TextBox>
        </EditItemTemplate>
   </asp:TemplateField>
   <asp:TemplateField HeaderText="FFFFE" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFFE" runat="server" Text='<%# Eval("FFFFE") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFFE" runat="server" Enabled="False" Text='<%# Eval("FFFFE") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
        <asp:TemplateField HeaderText="FFFFF" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblFFFFF" runat="server" Text='<%# Eval("FFFFF") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtFFFFF" runat="server" Enabled="False" Text='<%# Eval("FFFFF") %>'></asp:TextBox>
        </EditItemTemplate>
   </asp:TemplateField>
    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="false" ItemStyle-Width="150"/>
</Columns>
</asp:GridView>

                <asp:Panel ID="Panel1" runat="server">
                    <asp:Label ID="lblresult" runat="server" Text="Update results:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFF1" runat="server" Text="FFFF1:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFF2" runat="server" Text="FFFF2:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFF3" runat="server" Text="FFFF3:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFF4" runat="server" Text="FFFF4:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFF5" runat="server" Text="FFFF5:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFF6" runat="server" Text="FFFF6:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFF7" runat="server" Text="FFFF7:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFF8" runat="server" Text="FFFF8:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFF9" runat="server" Text="FFFF9:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFFA" runat="server" Text="FFFFA:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFFB" runat="server" Text="FFFFB:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFFC" runat="server" Text="FFFFC:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFFD" runat="server" Text="FFFFD:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFFE" runat="server" Text="FFFFE:"></asp:Label>
        <br />
        <asp:Label ID="lblFFFFF" runat="server" Text="FFFFF:"></asp:Label>
        <br />
                </asp:Panel>

      
        
                <asp:Panel ID="Panel2" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Error codes:"></asp:Label>
        <br />   
         <asp:Label ID="lblcd1" runat="server" Text="Return code 1:"></asp:Label>
        <br />
        <asp:Label ID="lblcd2" runat="server" Text="Return code 2:"></asp:Label>
        <br />
        <asp:Label ID="lblcd3" runat="server" Text="Return code 3:"></asp:Label>
        <br />
        <asp:Label ID="lblcd4" runat="server" Text="Return code 4:"></asp:Label>
        <br />
                </asp:Panel>
    </div>
    </form>
</body>
</html>