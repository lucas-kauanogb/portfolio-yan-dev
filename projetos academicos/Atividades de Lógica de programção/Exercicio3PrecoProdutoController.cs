using Microsoft.AspNetCore.Mvc;

namespace WebApiExercicioOperadorTernario.Controllers
{
    public class Exercicio3PrecoProdutoController : Controller
    {
        [HttpPost("PrecoProduto")]
        public string PrecoProduto(double precoInicial)
        {
            double resultado;
            resultado = (precoInicial > 100) ? precoInicial * 0.9 : precoInicial; 
            return $"Valor original: R${precoInicial}, Valor Final: R${resultado}" ;
        }
    }
}