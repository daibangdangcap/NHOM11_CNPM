﻿using System.Web;
using System.Web.Mvc;

namespace CNPM_DOAN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
