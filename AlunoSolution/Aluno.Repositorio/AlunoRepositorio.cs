using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aluno.Dominio;

namespace Aluno.Repositorio
{
    public interface IAlunoRepositorio
    {
        void Adicionar(Aluno aluno);
        List<int> Listar();
    }
}
