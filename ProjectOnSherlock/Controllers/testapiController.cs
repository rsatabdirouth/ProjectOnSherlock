using ProjectOnSherlock.Models;
using ProjectOnSherlock.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectOnSherlock.Controllers
{
    public class testapiController : ApiController
    {
        SherlockEntities _db = new SherlockEntities();
        [HttpGet]
        public IHttpActionResult data() {
            var leads = _db.Database.SqlQuery<Lead>("exec FINAL3_SP_LEADINFO_DATA").ToList();
            return Ok(leads); }

    }
}
