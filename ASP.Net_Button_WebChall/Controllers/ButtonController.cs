using ASP.Net_Button_WebChall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Net_Button_WebChall.Controllers
{
    public class ButtonController : Controller
    {
        // GET: Button

        static List<ButtonModel> buttons = new List<ButtonModel>();      //static'i kaldır değişimi gör

        Random r = new Random();
        public ActionResult Index()
        {
            for (int i = 0; i < 25; i++)
            {
                int x = r.Next(1, 9);
                {
                    buttons.Add(new ButtonModel(x));
                }



            }
            //buttons.Add(new ButtonModel(1));
           
            return View("Index", buttons);
        }
        public ActionResult HandleButtonClick(string mine)
        {
            int number = int.Parse(mine);
            if (buttons[number].State < 8)
            {
                buttons[number].State = buttons[number].State + 1;
            }
            else
            {
                buttons[number].State = 1;
            }
            return View("Index", buttons);
        }
    }
}