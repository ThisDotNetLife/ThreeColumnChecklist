using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiSite {
    public class Site {
        public int    SiteID         { get; set; }
        public string SiteName       { get; set; }
        public bool   IsCurrentSite  { get; set; }
        public int    HCOID          { get; set; }
        public int    GroupID        { get; set; }
        public int    NumOfResponses { get; set; }
    }
}