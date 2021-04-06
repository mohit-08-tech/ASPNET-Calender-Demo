<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPCalenderControlDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ASP .NET CALENDER CONTROL DEMO</div>
        <asp:Calendar ID="Calendar1" runat="server" Height="245px" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" Width="293px"></asp:Calendar>
        <p>
            <asp:TextBox ID="txtText" runat="server" Width="241px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
