using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentAngular.Controllers
{
    public class CitiesObject
    {
        public Newdataset NewDataSet { get; set; }
    }

    public class Newdataset
    {
        public Table[] Table { get; set; }
    }

    public class Table
    {
        public string Country { get; set; }
        public string City { get; set; }
    }
}