﻿using System.Web;
using System.Web.Mvc;

namespace proyectoWebII_empresa_asp.net
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
