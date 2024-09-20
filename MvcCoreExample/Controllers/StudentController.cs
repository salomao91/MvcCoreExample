using Dapper;
using Microsoft.AspNetCore.Mvc;
using MvcCoreExample.Models;
using System.Data.SqlClient;

namespace MvcCoreExample.Controllers
{
    public class StudentController : Controller
    {
        private readonly string _connectionString;

        public StudentController(IConfiguration connectionString)
        {
            _connectionString = connectionString.GetConnectionString("DefaultConnection");
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAll()
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                const string query = "SELECT * FROM Student";
                var students = await sqlConnection.QueryAsync<StudentModel>(query);
                return Ok(students);
            }
        }

    }
}
