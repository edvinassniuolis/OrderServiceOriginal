<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderWebForm.aspx.cs" Inherits="OrderClient.OrderWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <%--<form id="form1" runat="server">
        <table>
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Product</th>
                    <th>Quantity</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>                      
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td>
                    <asp:TextBox ID="ProductTextBox" runat="server"></asp:TextBox>                      
                    </td>
                    <td>
                        <asp:TextBox ID="QuantityTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="ViewButton" runat="server" Text="Click me!" OnClick="ViewButton_Click" />
                    </td>
                </tr>
            </tbody>
        </table>
    </form>--%>
    
    
    
    

    <form id="form2" runat="server">
        <table>
            
            <% for (int i = 0; i < value; i++) {%>
            <tr>
                    <td><asp:TextBox ID="GeneratedTextBox" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>
               <%} %>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                </td>
            </tr>       
        </table>
    </form>
</body>
</html>
