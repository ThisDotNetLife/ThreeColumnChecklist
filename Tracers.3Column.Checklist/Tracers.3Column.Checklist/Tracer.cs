using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiSite {
    [Serializable]
    public class Tracer {
        public int CustomTracerID      { get; set; }
        public string TracerName       { get; set; }
        public int TracerCustomGroupID { get; set; }
        public int HCOID               { get; set; }
    }
}