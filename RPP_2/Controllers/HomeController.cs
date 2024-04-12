using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RPP_2.Models;

namespace RPP_2.Controllers
{

    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            if (Session["current_id"] == null)
            {
                Session["current_id"] = "You're not client of this service";
            }
            else {

                Session["current_id"] = Database.last_index;
                
            }

            return View();
        }

        [HttpPost]
        public ActionResult Index(User user_data, string account_button)
        {

            if (account_button == "Edit")
            {

                int current_index = Database.last_index;

                int index = Database.list_users.FindIndex(user => user.id == Database.last_index);

                Database.list_users[index].name = user_data.name;
                Database.list_users[index].last_name = user_data.last_name;
                Database.list_users[index].date_birth = user_data.date_birth;
                Database.list_users[index].country = user_data.country;
                Database.list_users[index].phone_number = user_data.phone_number;

            }
            else if (account_button == "Submit")
            {

                Database.last_index += 1;

                User new_user = new User
                {
                    name = user_data.name,
                    last_name = user_data.last_name,
                    date_birth = user_data.date_birth,
                    country = user_data.country,
                    phone_number = user_data.phone_number,
                    id = Database.last_index
                };

                Database.list_users.Add(new_user);

                Session["current_id"] = Database.last_index.ToString();

            }

            return View(user_data);

        }

    }
}
