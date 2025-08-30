namespace Aluno.Dominio
{
    public class Aluno
    {
         public string Nome { get; set;  }
        public int Id { get; set;   } 
        public int Idade { get; set; }

        public bool EhMaiordeIdade() 
        {
            return Idade >= 18;
        }
        
    }
}
