using Microsoft.AspNetCore.Mvc;
using HelpDeskMvc.Models;

namespace HelpDeskMvc.Controllers
{
      public class ChamadosController : Controller

    {
        // lista em memória (simula o banco de dados)

        private static List<Chamado> chamados = new List<Chamado>
        {
            new Chamado
            {
                Id = 1,
                Titulo = "Sistema fora do ar",
                Descricao = "o sistema apresenta o erro 500.",
                Status = "Aberto",
                DataAbertura = DateTime.Now,
                DataFechamento = null

            },
        };

        private static int contadorId = 2;

        public IActionResult Index()
        {
            return View(chamados);
        }

    }
}