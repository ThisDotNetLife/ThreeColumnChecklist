<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MultiSite.Default" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        Table { font-family: Calibri; font-size:11pt; }
        TR { border: 1 solid black; }
        TD.chk { vertical-align: top;  
                 border-width: 1px;
    	         border-left-width: 1;
	             border-left-style : solid;
	             border-left-color: #808080;
	             border-top-width: 1;
	             border-top-style: solid;
	             border-top-color: #808080;	   
	             border-bottom-width: 1;
	             border-bottom-style: solid;
	             border-bottom-color: #808080; }
        TD.txt { vertical-align: top;  
                 border-width: 1px;
    	         border-right-width: 1;
	             border-right-style : solid;
	             border-right-color: #808080;
	             border-top-width: 1;
	             border-top-style: solid;
	             border-top-color: #808080;	   
	             border-bottom-width: 1;
	             border-bottom-style: solid;
	             border-bottom-color: #808080; }
    .rgDataDiv { overflow-x: hidden !important; }        
    	             
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <telerik:RadScriptManager ID="RadScriptManager1" Runat="server"></telerik:RadScriptManager>

            <asp:panel runat="server" Height="300px" Width="700px" ScrollBars="Vertical" BorderStyle="Solid" 
                       BorderWidth="1" EnableViewState="true" ID="pnlSites">            
                <asp:Table ID="tblSites" runat="server" CellPadding="0" CellSpacing="0">
                </asp:Table>
            </asp:panel>
        </div>
        <br />
    </form>
</body>
</html>

