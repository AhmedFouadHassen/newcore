using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newcore.Models
{
    public class datacountry : Icountry
    {
    
        public IEnumerable<Country> countries => NewMethod();

        private static IEnumerable<Country> NewMethod()
        {
            return new List<Country> {

                new Country { countryId = 1, countryname = "مصر" },
                new Country { countryId = 1, countryname = "السعودية" },
                new Country { countryId = 1, countryname = "الامارات" }
                };
          }

   
    }

      
    }

