using Microsoft.AspNetCore.Mvc;

namespace WebApiExercicioOperadorTernario.Controllers
{
    public class Exercicio1ParImparController : Controller
    {
        [HttpPost("VerificarNumeroParImpar")]
        public String VerificarNumeroParImpar(Int32 numero)
        {
            String resultado;

            //if (numero%2==0)
            //{
            //    resultado = "par";
            //}
            //else
            //{
            //    resultado = "impar";
            //}
            //Usando Operadores Ternários
            resultado = (numero % 2 == 0) ? "Par" : "Impar";
            return $"O {numero} é {resultado}"; 
        }
    }
}
