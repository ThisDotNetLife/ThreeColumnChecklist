using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace MultiSite
{
    public partial class Default : System.Web.UI.Page 
    {
        private const string SITE_ID ="SiteID";

        protected override void OnInit(EventArgs e) {
            base.OnInit(e);

            int numberOfRows = 3;

            IList<Site> colActiveSites = GetSites();

            Site[,] aryActiveSites = CovertListToMultiDimensionalArray(numberOfRows, colActiveSites);

            for (int row = 0; row < aryActiveSites.GetUpperBound(0) + 1; row++) {
                TableRow tempRow = new TableRow();
                for (int col = 0; col < aryActiveSites.GetUpperBound(1) + 1; col++) {

                    if (aryActiveSites[row, col] != null) {
                        TableCell cell01 = new TableCell();
                        CheckBox chkSite1 = new CheckBox();
                        chkSite1.ID = SITE_ID + aryActiveSites[row, col].SiteID.ToString();
                        chkSite1.AutoPostBack = false;
                        chkSite1.ClientIDMode = ClientIDMode.Static;
                        chkSite1.EnableViewState = true;
                        cell01.Controls.Add(chkSite1);
                        cell01.CssClass = "chk";
                        tempRow.Cells.Add(cell01);

                        TableCell cell02 = new TableCell();
                        cell02.Text = aryActiveSites[row, col].SiteName.ToString();
                        cell02.CssClass = "txt";
                        tempRow.Cells.Add(cell02);
                    }
                }
                tblSites.Rows.Add(tempRow);
            }
        }

        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack) {

            } else {
                // Process postback

                List<CheckBox> allControls = new List<CheckBox>();
                GetControlList<CheckBox>(Page.Controls, allControls);
                foreach (var childControl in allControls ) {
                    if (childControl.Checked) {
                        string siteID = childControl.ID.Replace(SITE_ID, "");
                        Response.Write(string.Format("You selected Site ID {0}<br />", siteID));
                    }
                }
            }
        }

        private Site[,] CovertListToMultiDimensionalArray(int pNumberOfColumns, IList<Site> pActiveSites) {

            // Calculate number of rows in table based on number of columns requested.
            int rowsInTable = pActiveSites.Count / pNumberOfColumns;
            if (pActiveSites.Count % pNumberOfColumns != 0) {
                rowsInTable += 1;
            }

            // Create array to hold the data from the collection.
            Site[,] activeSites = new Site[rowsInTable, pNumberOfColumns];
 
            // Transpose data from the collection in the array, imitating snaking columns.
            int row = 0; int col = 0;
            for (int i = 0; i < pActiveSites.Count; i++) {
		        
                if (row >= rowsInTable){
                    row = 0;
                    col+= 1;
                }
                activeSites[row, col] = pActiveSites[i];
                row += 1;
			}
            return activeSites;
        }

        private IList<Site> GetSites() {

            IList<Site> _ActiveSites = new List<Site>();

            _ActiveSites.Add(new Site { SiteID = 8577, HCOID = 35923, SiteName = "Kindred Hospital" });
            _ActiveSites.Add(new Site { SiteID = 8761, HCOID = 61224, SiteName = "Kindred Hospital  Brea" });
            _ActiveSites.Add(new Site { SiteID = 1422, HCOID = 5138, SiteName = "Kindred Hospital Albuquerque" });
            _ActiveSites.Add(new Site { SiteID = 3250, HCOID = 184367, SiteName = "Kindred Hospital Amarillo" });
            _ActiveSites.Add(new Site { SiteID = 1336, HCOID = 5005, SiteName = "Kindred Hospital Arizona- Phoenix/Scottsdale/Northwest" });
            _ActiveSites.Add(new Site { SiteID = 1334, HCOID = 5002, SiteName = "Kindred Hospital Atlanta" });
            _ActiveSites.Add(new Site { SiteID = 3230, HCOID = 181389, SiteName = "Kindred Hospital Aurora" });
            _ActiveSites.Add(new Site { SiteID = 6614, HCOID = 6960, SiteName = "Kindred Hospital Bay Area" });
            _ActiveSites.Add(new Site { SiteID = 1603, HCOID = 5509, SiteName = "Kindred Hospital Boston" });
            _ActiveSites.Add(new Site { SiteID = 3385, HCOID = 205012, SiteName = "Kindred Hospital Central Dakotas" });
            _ActiveSites.Add(new Site { SiteID = 3374, HCOID = 201609, SiteName = "Kindred Hospital Central Ohio" });
            _ActiveSites.Add(new Site { SiteID = 1407, HCOID = 5114, SiteName = "Kindred Hospital Central Tampa" });
            _ActiveSites.Add(new Site { SiteID = 1415, HCOID = 5129, SiteName = "Kindred Hospital Chattanooga" });
            _ActiveSites.Add(new Site { SiteID = 22653, HCOID = 518225, SiteName = "Kindred Hospital Chicago Central" });
            _ActiveSites.Add(new Site { SiteID = 1344, HCOID = 5018, SiteName = "Kindred Hospital Chicago Northlake" });
            _ActiveSites.Add(new Site { SiteID = 3943, HCOID = 299923, SiteName = "Kindred Hospital Clear Lake (Houston East/Baytown)" });
            _ActiveSites.Add(new Site { SiteID = 3755, HCOID = 274383, SiteName = "Kindred Hospital Cleveland" });
            _ActiveSites.Add(new Site { SiteID = 5703, HCOID = 401630, SiteName = "Kindred Hospital Corpus Christi" });
            _ActiveSites.Add(new Site { SiteID = 7672, HCOID = 9000, SiteName = "Kindred Hospital Dallas" });
            _ActiveSites.Add(new Site { SiteID = 10141, HCOID = 457397, SiteName = "Kindred Hospital Dallas Central" });
            _ActiveSites.Add(new Site { SiteID = 5735, HCOID = 402385, SiteName = "Kindred Hospital Dayton" });
            _ActiveSites.Add(new Site { SiteID = 1303, HCOID = 4938, SiteName = "Kindred Hospital Denver" });
            _ActiveSites.Add(new Site { SiteID = 3585, HCOID = 246381, SiteName = "Kindred Hospital Detroit" });
            _ActiveSites.Add(new Site { SiteID = 6612, HCOID = 6956, SiteName = "Kindred Hospital East" });
            _ActiveSites.Add(new Site { SiteID = 10520, HCOID = 462668, SiteName = "Kindred Hospital East LLC (Richmond)" });
            _ActiveSites.Add(new Site { SiteID = 4015, HCOID = 309746, SiteName = "Kindred Hospital Easton" });
            _ActiveSites.Add(new Site { SiteID = 4152, HCOID = 329652, SiteName = "Kindred Hospital El Paso" });
            _ActiveSites.Add(new Site { SiteID = 3399, HCOID = 207204, SiteName = "Kindred Hospital Fargo" });
            _ActiveSites.Add(new Site { SiteID = 5500, HCOID = 393001, SiteName = "Kindred Hospital Fort Worth" });
            _ActiveSites.Add(new Site { SiteID = 8685, HCOID = 51385, SiteName = "Kindred Hospital Greensboro" });
            _ActiveSites.Add(new Site { SiteID = 5200, HCOID = 380287, SiteName = "Kindred Hospital Heritage Valley" });
            _ActiveSites.Add(new Site { SiteID = 1357, HCOID = 5039, SiteName = "Kindred Hospital Houston" });
            _ActiveSites.Add(new Site { SiteID = 3711, HCOID = 265744, SiteName = "Kindred Hospital Houston North (Spring" });
            _ActiveSites.Add(new Site { SiteID = 1413, HCOID = 5127, SiteName = "Kindred Hospital Houston Northwest" });
            _ActiveSites.Add(new Site { SiteID = 1412, HCOID = 5126, SiteName = "Kindred Hospital Indianapolis South" });
            _ActiveSites.Add(new Site { SiteID = 1283, HCOID = 4899, SiteName = "Kindred Hospital Kansas City" });
            _ActiveSites.Add(new Site { SiteID = 8129, HCOID = 9888, SiteName = "Kindred Hospital La Mirada" });
            _ActiveSites.Add(new Site { SiteID = 8719, HCOID = 55529, SiteName = "Kindred Hospital Lafayette" });
            _ActiveSites.Add(new Site { SiteID = 1419, HCOID = 5135, SiteName = "Kindred Hospital Las Vegas Sahara" });
            _ActiveSites.Add(new Site { SiteID = 3343, HCOID = 197206, SiteName = "Kindred Hospital Lima" });
            _ActiveSites.Add(new Site { SiteID = 1366, HCOID = 5056, SiteName = "Kindred Hospital Los Angeles" });
            _ActiveSites.Add(new Site { SiteID = 1338, HCOID = 5007, SiteName = "Kindred Hospital Mansfield" });
            _ActiveSites.Add(new Site { SiteID = 15494, HCOID = 489616, SiteName = "Kindred Hospital Melbourne" });
            _ActiveSites.Add(new Site { SiteID = 8515, HCOID = 33707, SiteName = "Kindred Hospital Midtown" });
            _ActiveSites.Add(new Site { SiteID = 8533, HCOID = 34189, SiteName = "Kindred Hospital Milwaukee" });
            _ActiveSites.Add(new Site { SiteID = 9095, HCOID = 436175, SiteName = "Kindred Hospital Nashville" });
            _ActiveSites.Add(new Site { SiteID = 9109, HCOID = 436426, SiteName = "Kindred Hospital New Jersey Morris County" });
            _ActiveSites.Add(new Site { SiteID = 1382, HCOID = 5081, SiteName = "Kindred Hospital New Orleans" });
            _ActiveSites.Add(new Site { SiteID = 8672, HCOID = 50038, SiteName = "Kindred Hospital North Florida" });
            _ActiveSites.Add(new Site { SiteID = 1653, HCOID = 5614, SiteName = "Kindred Hospital Northeast" });
            _ActiveSites.Add(new Site { SiteID = 4963, HCOID = 368333, SiteName = "Kindred Hospital Northern IN" });
            _ActiveSites.Add(new Site { SiteID = 10685, HCOID = 465145, SiteName = "Kindred Hospital Northland" });
            _ActiveSites.Add(new Site { SiteID = 2650, HCOID = 102469, SiteName = "Kindred Hospital NW Indiana" });
            _ActiveSites.Add(new Site { SiteID = 9394, HCOID = 442124, SiteName = "Kindred Hospital Ocala" });
            _ActiveSites.Add(new Site { SiteID = 1408, HCOID = 5115, SiteName = "Kindred Hospital Oklahoma City" });
            _ActiveSites.Add(new Site { SiteID = 8180, HCOID = 9998, SiteName = "Kindred Hospital Ontario" });
            _ActiveSites.Add(new Site { SiteID = 14525, HCOID = 484161, SiteName = "Kindred Hospital Peoria" });
            _ActiveSites.Add(new Site { SiteID = 2483, HCOID = 84621, SiteName = "Kindred Hospital Philadelphia" });
            _ActiveSites.Add(new Site { SiteID = 5828, HCOID = 407047, SiteName = "Kindred Hospital Philly South" });
            _ActiveSites.Add(new Site { SiteID = 2775, HCOID = 117914, SiteName = "Kindred Hospital Pittsburgh" });
            _ActiveSites.Add(new Site { SiteID = 16195, HCOID = 495462, SiteName = "Kindred Hospital Pittsburgh North Shore" });
            _ActiveSites.Add(new Site { SiteID = 1365, HCOID = 5055, SiteName = "Kindred Hospital Sacramento" });
            _ActiveSites.Add(new Site { SiteID = 1294, HCOID = 4922, SiteName = "Kindred Hospital San Antonio" });
            _ActiveSites.Add(new Site { SiteID = 1401, HCOID = 5105, SiteName = "Kindred Hospital San Diego" });
            _ActiveSites.Add(new Site { SiteID = 1397, HCOID = 5100, SiteName = "Kindred Hospital San Francisco Bay Area" });
            _ActiveSites.Add(new Site { SiteID = 1424, HCOID = 5140, SiteName = "Kindred Hospital Seattle" });
            _ActiveSites.Add(new Site { SiteID = 18035, HCOID = 507544, SiteName = "Kindred Hospital Springfield" });
            _ActiveSites.Add(new Site { SiteID = 1353, HCOID = 5035, SiteName = "Kindred Hospital St. Louis" });
            _ActiveSites.Add(new Site { SiteID = 5139, HCOID = 377042, SiteName = "Kindred Hospital Sugarland (Town & Country)" });
            _ActiveSites.Add(new Site { SiteID = 6884, HCOID = 7437, SiteName = "Kindred Hospital Sycamore" });
            _ActiveSites.Add(new Site { SiteID = 12787, HCOID = 5079, SiteName = "Kindred Hospital Tarrant County Arlington" });
            _ActiveSites.Add(new Site { SiteID = 14070, HCOID = 478818, SiteName = "Kindred Hospital The Palm Beaches" });
            _ActiveSites.Add(new Site { SiteID = 8679, HCOID = 50653, SiteName = "Kindred Hospital Tucson" });
            _ActiveSites.Add(new Site { SiteID = 1410, HCOID = 5120, SiteName = "Kindred Hospital Tulsa" });
            _ActiveSites.Add(new Site { SiteID = 3253, HCOID = 184937, SiteName = "Kindred Hospital Victoria" });
            _ActiveSites.Add(new Site { SiteID = 3981, HCOID = 305085, SiteName = "Kindred Hospital White Rock" });
            _ActiveSites.Add(new Site { SiteID = 5101, HCOID = 375001, SiteName = "Kindred Hospital Wyoming Valley" });
            _ActiveSites.Add(new Site { SiteID = 1418, HCOID = 5133, SiteName = "Kindred Hospital-Boston Northshore" });
            _ActiveSites.Add(new Site { SiteID = 2583, HCOID = 96156, SiteName = "Kindred Hospitals Limited Partnership (Louisville" });
            _ActiveSites.Add(new Site { SiteID = 9307, HCOID = 440624, SiteName = "Kindred Rehabilitation Hospital Amarillo" });
            _ActiveSites.Add(new Site { SiteID = 8928, HCOID = 432660, SiteName = "Kindred Rehabilitation Hospital Arlington" });
            _ActiveSites.Add(new Site { SiteID = 10104, HCOID = 456812, SiteName = "Kindred Rehabilitation Hospital Central Texas" });
            _ActiveSites.Add(new Site { SiteID = 1359, HCOID = 5043, SiteName = "Kindred Rehabilitation Hospital Clear Lake" });
            _ActiveSites.Add(new Site { SiteID = 11556, HCOID = 475683, SiteName = "Kindred Rehabilitation Hospital St. Luke's" });
            _ActiveSites.Add(new Site { SiteID = 8283, HCOID = 10192, SiteName = "Kindred THC-Orange County" });
            _ActiveSites.Add(new Site { SiteID = 3673, HCOID = 259489, SiteName = "Specialty Hospital of South Carolina" });

            return _ActiveSites;
        }

        private void GetControlList<T>(ControlCollection controlCollection, List<T> resultCollection) where T : Control {
            foreach (Control control in controlCollection) {
                if (control is T)
                    resultCollection.Add((T)control);

                if (control.HasControls())
                    GetControlList(control.Controls, resultCollection);
            }
        }
    }
}