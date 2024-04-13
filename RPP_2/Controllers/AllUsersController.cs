using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RPP_2.Models;

namespace RPP_2.Controllers
{
    public class AllUsersController : Controller
    {
        //
        // GET: /AllUsers/

        public ActionResult Index()
        {

            TempData["method"] = Request.QueryString["kind_display_table_method"] == "internal";

            return View(Database.list_users);

        }

    }
}
