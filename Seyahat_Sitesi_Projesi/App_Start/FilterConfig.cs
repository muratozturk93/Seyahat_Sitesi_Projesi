﻿using System.Web;
using System.Web.Mvc;

namespace Seyahat_Sitesi_Projesi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
