<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tarea.aspx.cs" Inherits="Lab02_MarioMoraMontero.Forms.Tarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        
        <div>
            <h3 style="font-family:Algerian">Tarea 02</h3>
            Datos:
            <asp:TextBox runat="server" ID="txtNombre" placeholder="Nombre del estudiante"/>&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="txtPrimerApellido" placeholder="Primer apellido"/>&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="txtSegundoApellido" placeholder="Segundo apellido"/>&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="txtAnodeNacimiento" placeholder="Año de nacimiento"/>
            <br />
            <br />
            Datos estudiantiles: 
            <asp:TextBox runat="server" ID="txtNombreDelCurso" placeholder="Nombre del curso"/>&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="txtNota" placeholder="Nota"/>
            <br />
            <br />
            <asp:Button Text="Calcular" runat="server" ID="btnCalcular" OnClick="btnCalcular_Click"/>
            <br />
            <br />
            
            <asp:Label Text="" runat="server" ID="lblResultado"/>


        </div>
    </form>
        </center>
</body>
</html>
