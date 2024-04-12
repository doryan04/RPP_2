using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RPP_2.Models;

namespace RPP_2.Infrastructure
{
    public static class ListOfUsersMethod
    {
        public static MvcHtmlString ListOfUsersExternalMethod(this HtmlHelper html, List<User> AllUsers)
        {
            TagBuilder tbody = new TagBuilder("tbody");

            foreach (User user in AllUsers)
            {
                TagBuilder tag = new TagBuilder("tr");

                TagBuilder id = new TagBuilder("td");
                id.SetInnerText(user.id.ToString());

                TagBuilder name = new TagBuilder("td");
                name.SetInnerText(user.name);

                TagBuilder last_name = new TagBuilder("td");
                last_name.SetInnerText(user.last_name);

                TagBuilder country = new TagBuilder("td");
                country.SetInnerText(user.country);

                TagBuilder phone_number = new TagBuilder("td");
                phone_number.SetInnerText(user.phone_number.ToString());

                TagBuilder date_birth = new TagBuilder("td");
                date_birth.SetInnerText(user.date_birth.ToString());

                tag.InnerHtml += id.ToString();
                tag.InnerHtml += name.ToString();
                tag.InnerHtml += last_name.ToString();
                tag.InnerHtml += country.ToString();
                tag.InnerHtml += phone_number.ToString();
                tag.InnerHtml += date_birth.ToString();

                tbody.InnerHtml += tag.ToString();

            }
            return new MvcHtmlString(tbody.ToString());
        }
    }
}