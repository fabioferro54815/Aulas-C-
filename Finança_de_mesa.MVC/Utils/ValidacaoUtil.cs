using System;

namespace Finança_de_mesa.MVC.Utils
{
    public class ValidacaoUtil
    {
        public static bool ValidarEmail(string email){
            if(email.Contains("@") && email.Contains(".")){
                return true;
            }else{
                return false;
            }
        }

        public static bool ValidarSenha(string senha, string confirmaSenha){
            if(senha.Equals(confirmaSenha) && senha.Length >= 6)
            {
                return true;
            }else{
                return false;
            }
        }

        public static bool ValidarAnoNascimento(int ano){
            if(ano <= DateTime.Now.Year)
            {
                return false;
            }else{
                return true;
            }
        }
    }
}