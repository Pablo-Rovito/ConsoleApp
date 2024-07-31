using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace ConsoleApp.Controllers {
    /// <summary>
    /// This controller tests DB connection's health. \n If status 200, then the connection is open. If not, then not.
    /// </summary>
    /// <returns>status 200 with text "OK"; otherwise, a 500 error with text "ERROR".</returns>
    /// <response code="200">OK</response>
    /// <response code="500">ERROR</response>
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseTestController : ControllerBase {
        private readonly string _connectionString = "Host=localhost;Port=5432;Database=ConsoleAppDB;Username=postgres;Password=Estrella.Roja.1917";

        [HttpGet]
        public IActionResult TestConnection() {
            try {
                Console.WriteLine("Attempting connection to DB...");
                using var conn = new NpgsqlConnection(_connectionString);
                conn.Open();
                return Ok("OK");
            } catch (Exception) {
                Console.WriteLine("Connection failed");
                return StatusCode(500, "ERROR");
            }
        }
    }
}
