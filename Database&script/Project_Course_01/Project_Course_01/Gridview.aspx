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
        COURSE_ID:<br />
        <asp:TextBox ID="txtSearchCOURSE_ID" runat="server" Width="140" />
    </td>
    <td style="width: 100px">
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="Search" />
    </td>
        <td style="width: 100px">
        <asp:Button ID="btnShowAll" runat="server" Text="Show all" OnClick="Showall" />
    </td>
</tr>
</table>
    <asp:GridView ID="gvCOURSE" runat="server" AutoGenerateColumns="false" DataKeyNames="COURSE_ID"
OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
OnRowUpdating="OnRowUpdating">
<Columns>
    <asp:TemplateField HeaderText="COURSE_ID" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblCOURSE_ID" runat="server" Text='<%# Eval("COURSE_ID") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtCOURSE_ID" runat="server" Enabled="False" Text='<%# Eval("COURSE_ID") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="TITLE" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblTITLE" runat="server" Text='<%# Eval("TITLE") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtTITLE" runat="server" Enabled="True" Text='<%# Eval("TITLE") %>'></asp:TextBox>
        </EditItemTemplate>
   </asp:TemplateField>
   <asp:TemplateField HeaderText="COURSE_EFF_DATE" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblCOURSE_EFF_DATE" runat="server" Text='<%# Eval("COURSE_EFF_DATE") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtCOURSE_EFF_DATE" runat="server" Enabled="True" Text='<%# Eval("COURSE_EFF_DATE") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
        <asp:TemplateField HeaderText="COURSE_EXP_DATE" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblCOURSE_EXP_DATE" runat="server" Text='<%# Eval("COURSE_EXP_DATE") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtCOURSE_EXP_DATE" runat="server" Enabled="True" Text='<%# Eval("COURSE_EXP_DATE") %>'></asp:TextBox>
        </EditItemTemplate>
   </asp:TemplateField>
   <asp:TemplateField HeaderText="DURATION" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblDURATION" runat="server" Text='<%# Eval("DURATION") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtDURATION" runat="server" Enabled="True" Text='<%# Eval("DURATION") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="COST" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblCOST" runat="server" Text='<%# Eval("COST") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtCOST" runat="server" Enabled="True" Text='<%# Eval("COST") %>'></asp:TextBox>
        </EditItemTemplate>
   </asp:TemplateField>
   <asp:TemplateField HeaderText="SUBJECT_ID" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblSUBJECT_ID" runat="server" Text='<%# Eval("SUBJECT_ID") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtSUBJECT_ID" runat="server" Enabled="True" Text='<%# Eval("SUBJECT_ID") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>
        <asp:TemplateField HeaderText="UPDATE_TS" ItemStyle-Width="50">
        <ItemTemplate>
            <asp:Label ID="lblUPDATE_TS" runat="server" Text='<%# Eval("UPDATE_TS") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtUPDATE_TS" runat="server" Enabled="False" Text='<%# Eval("UPDATE_TS") %>'></asp:TextBox>
        </EditItemTemplate>
   </asp:TemplateField>

    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="false" ItemStyle-Width="150"/>
</Columns>
</asp:GridView>
                <asp:Panel ID="Panel1" runat="server">
                    <asp:Label ID="lblresult" runat="server" Text="Update results:"></asp:Label>
        <br />
        <asp:Label ID="lblTITLE" runat="server" Text="TITLE:"></asp:Label>
        <br />
        <asp:Label ID="lblCOURSE_EFF_DATE" runat="server" Text="COURSE_EFF_DATE:"></asp:Label>
        <br />
        <asp:Label ID="lblCOURSE_EXP_DATE" runat="server" Text="COURSE_EXP_DATE:"></asp:Label>
        <br />
        <asp:Label ID="lblDURATION" runat="server" Text="DURATION:"></asp:Label>
        <br />
        <asp:Label ID="lblCOST" runat="server" Text="COST:"></asp:Label>
        <br />
        <asp:Label ID="lblSUBJECT_ID" runat="server" Text="SUBJECT_ID:"></asp:Label>
        <br />
        <asp:Label ID="lblUPDATE_TS" runat="server" Text="UPDATE_TS:"></asp:Label>
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




