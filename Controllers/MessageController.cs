using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace ConsoleApp.Controllers {
    /// <summary>
    /// Gets the message stored in DB by the given id.
    /// </summary>
    /// <param name="id">The id of the message to retrieve.</param>
    /// <returns>The message text if found; otherwise, a 404 error.</returns>
    /// <response code="200">Returns the message text.</response>
    /// <response code="404">If the message is not found.</response>
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase {
        private readonly string _connectionString = "Host=localhost;Port=5432;Database=ConsoleAppDB;Username=postgres;Password=Estrella.Roja.1917";

        [HttpGet("{id}")]
        public IActionResult GetMessageById(string id) {
            try {
                Console.WriteLine("Attempting connection to DB...");
                using var conn = new NpgsqlConnection(_connectionString);
                conn.Open();

                string query = "SELECT text FROM \"Messages\" WHERE id=@id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id", id);

                using var reader = cmd.ExecuteReader();

                return !reader.Read() 
                    ? NotFound("Couldn't find entries for that id") 
                    : Ok(reader.GetString(0));

            } catch (Exception) {
                Console.WriteLine("Connection failed");
                return StatusCode(500, "ERROR");
            }
        }
    }
}