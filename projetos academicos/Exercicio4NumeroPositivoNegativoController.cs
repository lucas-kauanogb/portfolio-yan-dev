using Microsoft.AspNetCore.Mvc;

namespace WebApiExercicioOperadorTernario.Controllers
{
    public class Exercicio4NumeroPositivoNegativoController : Controller
    {
        [HttpPost("NumeroPositivoNegativo")]
        public String NumeroPositivoNegativo(Int32 numero)
        {
            string resultado;
            resultado = (numero > 0) ? "positivo." : (numero < 0) ? "negativo." : "zero.";
            return $"O número é {resultado}";
        }
    }
}
