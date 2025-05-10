using Microsoft.AspNetCore.Mvc;

namespace WebApiExercicioOperadorTernario.Controllers
{
    public class Exercicio2NotaAlunoController : Controller
    {
        [HttpPost("VerificarAprovadoReprovado")]
        public String VerificarAprovadoReprovado(Double nota)
        {
            string resultado;
            resultado = ((nota >= 0) && (nota <= 10)) ? (nota >= 6) ? "Aprovado" : "Reprovado" : "Informe uma número entre 0 e 10";
            return $"O aluno está {resultado}";
        }
    }
}
