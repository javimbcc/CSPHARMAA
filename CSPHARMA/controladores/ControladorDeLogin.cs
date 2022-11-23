using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Npgsql;
using System.Data;
using System.Data.Common;

/*
 * Controlador del login, el cuál contiene un metodo para mostrar en si el login y el otro el método por el que validamos lo que viene
 * @author Jmenabc
 */

namespace CSPHARMA.controladores
{
    public class ControladorDeLogin : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Index(String name, String password)
        {
            using var connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=root");
            Console.WriteLine("HABRIENDO CONEXION");
            connection.Open();
            NpgsqlCommand consulta = new NpgsqlCommand($"SELECT * FROM \"public\".\"users\" WHERE usuario_nick='{name}' AND usuario_password='{password}'", connection);
            NpgsqlDataReader resultadoConsulta = consulta.ExecuteReader();

            if (resultadoConsulta != null)
            {
                Console.WriteLine("Ha iniciado sesion con exito");
            }
            else
            {
                Console.WriteLine("Recuerde sus credenciales");
            }
            Console.WriteLine("Cerrando conexion");
            connection.Close();
            return View();
        }


    }
}
