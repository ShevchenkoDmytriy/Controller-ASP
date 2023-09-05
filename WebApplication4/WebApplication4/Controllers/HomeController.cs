using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public async Task Index()
        {
            string content = @"<form method='post'>

        <label> FIO:</label><br>
        <input name='name'/><br>
        <label> Date:</label><br>
        <input  name='date'/><br>
        <label> City:</label><br>
        <input  name='city'/><br>
        <input type='submit' value='Send'/>
        </form>";

            Response.ContentType = "text/html; charset=utf8";
            await Response.WriteAsync(content);
        }

        [HttpPost]
        public string Index(string name, string date, string city) => $"{name}: {date} , {city}";
    }
}
