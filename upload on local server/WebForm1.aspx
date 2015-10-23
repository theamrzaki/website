<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="upload_on_local_server.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="divv">
        <p>select a file to upload
    <asp:FileUpload runat="server" ID="FileUpload1" />
            </p>
        <asp:Button ID="Button" OnClick="Button_Click" runat="server" Text="upload" />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <asp:Image runat="server" ID="myimage" />
    </div>
    </form>
</body>
</html>
