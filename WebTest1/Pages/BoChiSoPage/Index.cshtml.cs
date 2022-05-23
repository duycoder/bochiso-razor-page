using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using WebTest1.Model;

namespace WebTest1.Pages.BoChiSoPage
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IEnumerable<BoChiSo> ListBoChiSo { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet()
        {
            ListBoChiSo = await _db.BoChiSo.ToListAsync();
        }

        //public IActionResult OnPostGeoLocation()
        //{
        //    return new JsonResult("OnPostGeoLocation CALLED ####################################");
        //}

        //public PartialViewResult OnPostFormEditBoChiSo(long id = 0)
        //{
        //    var infoBoChiSo = _db.BoChiSo.Find(id) ?? new BoChiSo();
        //    return new PartialViewResult
        //    {
        //        ViewName = "_EditBoChiSo",
        //        ViewData = infoBoChiSo,
        //        Model = infoBoChiSo
        //    };
        //}


        public PartialViewResult OnPostFormEditBoChiSo(int id = 0)
        {
            var infoBoChiSo = _db.BoChiSo.Find(id) ?? new BoChiSo();
            return new PartialViewResult
            {
                ViewName = "_EditBoChiSo",
                ViewData = new ViewDataDictionary<BoChiSo>(ViewData, infoBoChiSo),
            };
        }

    }
}
