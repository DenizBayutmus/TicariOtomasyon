using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineTicariOtomasyon2.Models.Siniflar
{
    public class Class3
    {
        IEnumerable<SelectListItem> Kategoriler { get; set; }
        IEnumerable<SelectListItem> Urunler { get; set; }
    }
}