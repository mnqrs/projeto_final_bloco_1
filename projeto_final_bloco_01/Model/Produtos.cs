using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    internal class Produtos : Macaco

    {
        private string comidas;
        private string roupas;

        public Produtos(int id, int preço, string nome, string descrição, string comidas, string roupas) : base(id, preço, nome, descrição)
        {
            this.comidas = comidas;
            this.roupas = roupas;
        }
        public string GetComidas()
        {
            return comidas;
        }
        public void SetComidas(string comidas)
        {
            this.comidas = comidas;
        }
        public string GetRoupas()
        {
            return roupas;

        }
        public void SetRoupas(string roupas)
        {
            this.roupas = roupas;
        }
        public virtual void Visualizar()
        {
            string tipo = string.Empty;


            Console.WriteLine("********************************************");
            Console.WriteLine("Monkey and co");
            Console.WriteLine("********************************************");
            Console.WriteLine($"Roupas: {this.roupas}");
            Console.WriteLine($"Comidas: {this.comidas}");
        }
    }
}
