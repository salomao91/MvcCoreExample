using Dapper;
using Microsoft.AspNetCore.Mvc;
using MvcCoreExample.Models;
using System.Data.SqlClient;

namespace MvcCoreExample.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly string _connectionString;

        public ProfessorController(IConfiguration connectionString)
        {
            _connectionString = connectionString.GetConnectionString("DefaultConnection");
        }

        public async Task<IActionResult> Index()
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                const string query = "SELECT * FROM Professor";
                var professors = await sqlConnection.QueryAsync<ProfessorModel>(query);
                return View(professors);
            }
        }
    }
}
