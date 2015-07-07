using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelperDemo.Models
{
    public class Organisation
    {
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string AddressLocality { get; set; }
        public string AddressRegion { get; set; }
        public string PostalCode { get; set; }

        public static Organisation WellKnownCompany
        {
            get
            {
                return new Organisation
                {
                    Name = "Cyberdyne",
                    StreetAddress = "18144 El Camino Real",
                    AddressLocality = "Sunnyvale",
                    AddressRegion = "WA",
                    PostalCode = "California"
                };
            }
        }
    }
}
