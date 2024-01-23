using DIYCraftsAndProjectsMVC.Mapper;
using DIYCraftsAndProjectsMVC.Models;
using DIYCraftsAndProjectsMVC.Models.BLModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

/* 
 * SOLID PRINCIPI
 * 
 * S kao Single Responsibility Princip (SRP)
 * Svaka metoda u klasi je odgovorna za jednu stvar
 * Login metoda za Logiranje korisnika u sustav a
 * Register metoda za registraciju novog korisnika
 * 
 * O kao Open/Closed Princip (OCP)
 * 
 * L kao Liskov Substitution Principle (LSP)
 * 
 * I kao Interface Segregation Principle (ISP)   
 * 
 * D kao Dependency Inversion Principle (DIP)
 * AccountController klasa ovisi o apstrakciji CraftsAndProjectsDbContext-a 
 * koju dodajemo u konstruktoru klase, što znači da
 * AccountController nije direktno ovisan o konkretnoj implementaciji CraftsAndProjectsDbContext-a  * 
 * 
 * DESIGN PATTERNI
 * 
 * Dependency Injection (DI)
 * CraftsAndProjectsDbContext se ubacuje (inject) u AccountController preko konstruktora.
 * Govorimo o IoC-u ili inverziji kontrole, time smanjujemo isprepletenost (copuling)
 * između klasa i mičemo odgovornost upravljanja Dependenci-ja izvan klase
 * 
 * Repository Pattern
 * CraftsAndProjectsDbContext se koristi kao apstrakcija detalja 
 * odnosno načina pristupa izvoru podataka, u ovom slučaju baze podataka,
 * čime dobivamo jednostavan način za izvođenje CRUD-a bez redudancije
 * 
 * Data Mapper Pattern
 * UserAccountMapper.MapAccountToUser(account) koristi taj pattern.
 * mapiramo dva različita tipa podatka, Account i User-a tako da su neovisni jedan o drugome
 * 
 * 
*/
namespace DIYCraftsAndProjectsMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly CraftsAndProjectsDbContext _context;

        public AccountController(CraftsAndProjectsDbContext context)
        {
            _context = context;
        }

        // GET: AccountController
        public ActionResult Login()
        {
            return View();
        }

        // GET: AccountController/Create
        //public ActionResult Create()
        //{
        //    return View();e
        //}

        // POST: AccountController/Create
        [HttpPost]
        public ActionResult Login(Login login)
        {
            try
            {
                var user = _context.Users.Where(x => x.Email == login.Email && x.Password == login.Password).Count();

                if (user > 0)
                {
                    return RedirectToAction("Index", "Post");
                }
                return RedirectToAction("Login");
            }
            catch
            {
                return RedirectToAction("Login");
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Register()
        {
            var countries = _context.Countries.ToList();

            ViewBag.Countries = new SelectList(countries, "CountryId", "CountryName");

            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        public ActionResult Register(Account account)
        {
            try
            {
                _context.Users.Add(UserAccountMapper.MapAccountToUser(account));
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            catch
            {
                return View();
            }
        }
    }
}
