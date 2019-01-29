﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InsuranceApp.ViewModels;

namespace InsuranceApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (QuotesEntities db = new QuotesEntities())
            {

                var quotes = db.Quotes;
                var QuoteVms = new List<QuoteVm>();
                foreach (var Quotes in quotes)
                {

                    //var is named "Quotes" rather than "Quote" because the title
                    //of the edmx table couldn't be the same as the parameter "Quote".
                    var QuoteVm = new QuoteVm();
                    QuoteVm.Quote = Convert.ToDouble(Quotes.Quote);
                    QuoteVm.FirstName = Quotes.FirstName;
                    QuoteVm.LastName = Quotes.LastName;
                    QuoteVm.EmailAddress = Quotes.EmailAddress;
                    //QuoteVm.Quote = Quotes.Quote;
                    QuoteVms.Add(QuoteVm);


                }
                return View(QuoteVms);
            }
        }
    }
}