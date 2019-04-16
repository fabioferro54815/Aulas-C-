using System;

namespace OO
{
    class Usuario
    {
        int codigo = 123;
        string nome = "Fulano";
        string curso = "Dev";
        string senha = "123";
        DateTime dataNascimento;

        public string InserirSenha() {
            return senha;
        }
    }
}
