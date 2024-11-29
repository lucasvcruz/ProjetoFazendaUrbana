using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MeuSite.Controllers
{
    public class HomeController : Controller
    {

        SqlConnection connection = new SqlConnection("Server=LucasCruz; Database=BoniniFarm2; Integrated Security=True; TrustServerCertificate=True");
        public HomeController()
        {
            connection.Open();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult RegistrarPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(string Nome, string CNPJ, string CPF, string Email, string Senha)
        {
            // Valida o login
            bool isValid = FazerRegistro(Nome, CNPJ, CPF, Email, Senha);

            if (isValid)
            {
                TempData["SuccessMessage"] = "Usuário registrado com sucesso!";
                return RedirectToAction("AcompanharCultivo");
            }
            else
            {
                // Se o login falhar, exibe uma mensagem de erro
                ViewBag.ErrorMessage = "Não foi possível completar o ato de registrar";
                return View();
            }

        }
        public bool FazerRegistro(string Nome, string CNPJ, string CPF, string Email, string Senha)
        {
            string query = "INSERT INTO Cliente (nome_cli, CNPJ_cli, CPF_cli, login_cli, senha_cli) VALUES (@Nome, @CNPJ, @CPF, @Email, @Senha)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nome", Nome);
                command.Parameters.AddWithValue("@CNPJ", CNPJ);
                command.Parameters.AddWithValue("@CPF", CPF);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Senha", Senha);


                int userCount = command.ExecuteNonQuery();

//                int userCount = (int)command.ExecuteScalar();

                if (userCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    


        public ActionResult LoginPage()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            // Valida o login
            bool isValid = FazerLogin(username, password);

            if (isValid)
            {
                // Redireciona para a página inicial após o login bem-sucedido
                return RedirectToAction("AcompanharCultivo");
            }
            else
            {
                // Se o login falhar, exibe uma mensagem de erro
                ViewBag.ErrorMessage = "Usuário ou senha incorretos.";
                return View();
            }
        }

        // Função de validação do login
        public bool FazerLogin(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM dbo.Cliente WHERE login_cli = @Username AND senha_cli = @Password;";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public ActionResult AcompanharCultivo()
        {
            return View();
        }

    }
}
