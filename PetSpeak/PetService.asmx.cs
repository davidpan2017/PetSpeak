using PetModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace PetSpeak
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<PetBase> GetPalindromePetList()
        {
            House petHouse = new House();
            petHouse.AddTestData();
            return petHouse.GetPalindromePets();
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string ShowPetList()
        {
            StringBuilder strHTML =  new StringBuilder();
            
            strHTML.Append("<table class='petTable'>");
            strHTML.Append("<tr class = 'petHeader'>");
            strHTML.Append("<td class='petCell'>" + "Name" + "</td>");
            strHTML.Append("<td class='petCell'>" + "Is Panlindrome?" + "</td>");
            strHTML.Append("<td class='petCell'>" + "Type" + "</td>");
            strHTML.Append("<td class='petCell'>" + "Gender" + "</td>");
            strHTML.Append("<td class='petCell'>" + "Age" + "</td>");
            strHTML.Append("<td class='petCell'>" + "Wingspan" + "</td>");
            strHTML.Append("<td class='petCell'>" + "Speak" + "</td>");
            strHTML.Append("</tr>");


            House petHouse = new House();
            petHouse.AddTestData();


            foreach (PetBase pet in petHouse)
            {
                strHTML.Append("<tr class = 'petRow'>");
                strHTML.Append("<td class='petCell'>" + pet.Name + "</td>");
                strHTML.Append("<td class='petCell'>" + pet.IsNameAPalindrome.ToString() + "</td>");
                strHTML.Append("<td class='petCell'>" + pet.GetType().Name + "</td>");
                strHTML.Append("<td class='petCell'>" + pet.Gender.ToString() + "</td>");
                strHTML.Append("<td class='petCell'>" + pet.Age.ToString() + "</td>");
                if (pet.GetType() == typeof(Bird))
                {
                    strHTML.Append("<td class='petCell'>" + ((Bird)pet).Wingspan.ToString() + "</td>");
                }
                else
                {
                    strHTML.Append("<td class='petCell'>" + "" + "</td>");
                }

                strHTML.Append("<td class='petCell'>" 
                    + "<a class=\"btn btn-primary btn-lg\" onclick=\"PetSpeak('" + pet.Speak()+"');return false;\">Speak</a>" 
                    + "</td>");

                strHTML.Append("</tr>");
            }


            strHTML.Append("</table>");

            return strHTML.ToString();


        }


    }
}
