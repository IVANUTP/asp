<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Empleados.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="estilos/Style.css" rel="stylesheet" />
    <title>My page web</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Vacunas </h1>
             <br />
            <div>
                 <label>Solicita tu edad :</label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
           
            <br />
      
            <div>
                <asp:Button ID="Button1" runat="server" Text="Sumit" OnClick="Button1_Click" />
            </div>
        </div>
        <br />
       <div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
         <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
       </div>
        

    </form>

</body>
</html>
