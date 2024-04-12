using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RPP_2.Models
{

    [DisplayName("New user")]
    public class User
    {

        [HiddenInput]
        public int id { get; set; }

        [DisplayName("Name")]
        public string name { get; set; }

        [DisplayName("Last name")]
        public string last_name { get; set; }

        [DisplayName("Date birth")]
        public DateTime date_birth { get; set; }

        [DisplayName("County")]
        public string country { get; set; }

        [DisplayName("Phone number")]
        [DataType(DataType.PhoneNumber)]
        public string phone_number { get; set; }

    }

}