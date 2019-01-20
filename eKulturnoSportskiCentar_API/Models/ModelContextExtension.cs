using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eKulturnoSportskiCentar_API.Models
{
    public partial class eKulturnoSportskiCentar_Entities : DbContext 
    {

        public eKulturnoSportskiCentar_Entities(bool LazyLoading = false)
        {
            Configuration.LazyLoadingEnabled = LazyLoading;
           Configuration.ProxyCreationEnabled = false;
        }
    }
}