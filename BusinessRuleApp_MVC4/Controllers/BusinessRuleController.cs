using System.Web.Mvc;
using BusinessRuleApp_MVC4.Models;
using System.Globalization;

namespace BusinessRuleApp_MVC4.Controllers
{
    public class BusinessRuleController : Controller
    {
        // GET: /BusinessRule/Add (URL format) > Access for all users
        public ActionResult Add()
        {
            //Create a new Business Rule
            BusinessRule newBusinessRule = new BusinessRule();
            newBusinessRule.userCreation = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(User.Identity.Name);
            newBusinessRule.CreationDate = System.DateTime.Today;
            return View(newBusinessRule);
        }

    }
}