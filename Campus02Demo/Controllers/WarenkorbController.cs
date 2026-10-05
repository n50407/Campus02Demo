using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Campus02Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarenkorbController : ControllerBase
    {
        //dotnet new webapi -n Campus02Demo
        //Controller: //BackAccountController
        //HttpPost["Geldeinzahlen"]
        //HttpPost["Geldabheben"]   
        //Deposit(200), Withdraw(300), GetBalance();
        //static double balance = 0;

        static List<string> produkte = new List<string>();


        //Produkt hinzufügen
        //alle Produkte im Warenkorb anzeigen
        [HttpPost("add")]
        public IActionResult PostAddNewProdukt(string produktName)
        {

            if (produktName == "Tisch")
            {
                return BadRequest();

            }
            else
            {
                produkte.Add(produktName);
                return Ok();
            }
        }

        [HttpGet("all")]
        public List<string> GetAllProdukte()
        {
            return produkte;
        }
    }
}
