using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Repository
{
    internal interface Repository
    {
        public void CadastrarProduto(int id);
        public void ListarTodas();
        public void Cadastrar(string nome);
        public void Atualizar(int preço);
        public void Deletar(int numero);
    }
}
