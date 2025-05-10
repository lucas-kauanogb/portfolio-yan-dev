using Microsoft.AspNetCore.Mvc;

namespace ApiExemplosRepeticao.Controllers
{
    public class ExemploEstruturaRepeticao1Controller : Controller
    {
        [HttpPost("ExEstruturaRepeticaoTesteInicio")]
        public String ExEstruturaRepeticaoTesteInicio(int numeroUsuario)
        {
            string resultado = "";
            int contador = 0;
            while (numeroUsuario < 100)
            {
                resultado += $"Seja bem-vindo Usuário {numeroUsuario}\n\r";
                numeroUsuario++;
            }
            return resultado;

        }
        [HttpPost("ExEstruturaRepeticaoTesteFinal")]
        public String ExEstruturaRepeticaoTesteFinal(int numeroUsuario)
        {
            string resultado = "";
            do
            {
                numeroUsuario++;
                resultado += $"Seja bem-vindo Usuário {numeroUsuario}\n\r";
            } while (numeroUsuario < 100);

            return resultado;
        }
        [HttpPost("ExEstruturaRepeticaoComVariaveis")]
        public String ExEstruturaRepeticaoComVariaveis(int numeroUsuario)
        {
            string resultado = "";
            for (int i = 0; i <= 10; i++)
            {
                resultado += $"Usuário {i}\r\n";

            }
            return resultado;
        }
        [HttpPost("ExemploSomaSerie")]
        public String ExemploSomaSerie()
        {
            string resultado = "";
            double soma, numerador, denominador;
            soma = 0;
            numerador = 1;
            denominador = 1;
            do
            {
                soma = soma + (numerador / denominador);
                numerador = numerador + 2;
                denominador = denominador + 1;

            } while (denominador <= 50);
            resultado = $"A soma da série é {soma}";
            return resultado;

        }
    }
}


