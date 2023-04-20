namespace Construtores
{
    public class Aluno
    {
        public string Nome {get; set;}
        public int Matricula {get; set;}
        public string Endereco {get; set;}
        public string Telefone {get; set;}
        public DateTime DataCracao {get;set;}
        public Aluno()
        {
            DataCracao = DateTime.Now;
        }
        public Aluno(string nome, int matricula): this(){
            Nome = nome;
            Matricula = matricula;
        }
        //This() é utilizado para interligar os construtores a fim de evitar repetição de código
        public Aluno(string nome, int matricula, string endereco, string telefone) : this(nome, matricula){
            Endereco = endereco;
            Telefone = telefone;
        }
        //Mas nada impede de possuir construtores independentes
        public Aluno(string nome, string endereco){
            Endereco = endereco;
            DataCracao = DateTime.Now;
            Nome = endereco;
        }
    }
}