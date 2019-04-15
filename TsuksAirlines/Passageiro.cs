using System;

namespace TsuksAirlines
{
    class Passageiro
    {
       
       string nome;
       int numeroPassagem;
       DateTime data;

       public void setNome(string nome) {
           this.nome = nome;
       }

       public string getNome() {
           return this.nome;
       }

       public void setnumeroPassagem(int numeroPassagem) {
           this.numeroPassagem = numeroPassagem;
       }

       public int getnumeroPassagem() {
           return this.numeroPassagem;
       }
       public void setdata(DateTime data) {
           this.data = data;
       }

       public DateTime getdata() {
           return this.data;
       }
    }
}
