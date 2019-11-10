using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiSite {
    public class MultiSite {
        IList<Tracer> _Tracers = new List<Tracer>();

        // Constructor
        public MultiSite() {
            _Tracers.Add(new Tracer { CustomTracerID = 1155, TracerName = "Inpatient Generic Tracer", TracerCustomGroupID = 1, HCOID = 5007 });
            _Tracers.Add(new Tracer { CustomTracerID = 1156, TracerName = "National Patient Safety Goals", TracerCustomGroupID = 2, HCOID = 5007 });
            _Tracers.Add(new Tracer { CustomTracerID = 2266, TracerName = "GroupLess", TracerCustomGroupID = 0, HCOID = 5007 });
        }

        // Methods
        public IList<Tracer> GetTracers() {
            return _Tracers;
        }
    }
}