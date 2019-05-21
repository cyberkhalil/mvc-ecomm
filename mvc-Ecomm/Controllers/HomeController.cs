using System.Web.Mvc;

namespace mvc_ecomm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // GET: Home/Index
        public ActionResult Index() { return View(); }

        // GET: Home/Cart
        public ActionResult Cart() { return View(); }

        // GET: Home/Checkout
        public ActionResult Checkout() { return View(); }

        // GET: Home/Login
        public ActionResult Login() { return View(); }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {

            if (username == password) return Redirect("/Accounts/");
            else return View();
        }

        [HttpPost]
        public ActionResult Signup(string name, string username, string password)
        {
            // TODO create account.
            return View("Login");
        }

        // GET: Home/PageNotFound
        public ActionResult PageNotFound() { return View(); }

        // GET: Home/ProductDetails
        public ActionResult ProductDetails() { return View(); }

        // GET: Home/Shop
        public ActionResult Shop() { return View(); }
    }
}