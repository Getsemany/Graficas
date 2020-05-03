<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Graficas.aspx.cs" Inherits="Graficas" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Grafica {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <asp:Chart ID="Graf" runat="server" OnLoad="Chart1_Load" style="text-align: center">
                <Series>
                    <asp:Series Name="Series"></asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea"></asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
        </div>
    </form>
</body>
</html>
