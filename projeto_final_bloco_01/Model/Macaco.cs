using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projeto_final_bloco_01.Model
{
    public abstract class Macaco
    {
    private int id;
    private int preço;
    private string nome = string.Empty;
    private string descrição = string.Empty;



        public Macaco(int id, int preço, string nome, string descrição)
    {
        this.id = id;
        this.preço = preço;
        this.nome = nome;
        this.descrição = descrição;
      
    }

     public Macaco() { }

    
    public int GetId()
    {
        return id;
    }

    public void SetId(int id)
    {
        this.id = id;
    }

    public int GetPreço()
    {
        return preço;
    }

    public void SetPreço(int preço)
    {
        this.preço = preço;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public string GetDescrição()
    {
        return descrição;
    }

    public void SetTitular(string descrição)
    {
        this.descrição = descrição;
    }

    
   

    public virtual void Visualizar()
    {
        string tipo = string.Empty;


        Console.WriteLine("********************************************");
        Console.WriteLine("Monkey and co");
        Console.WriteLine("********************************************");
        Console.WriteLine($"Id do Produto: {this.id}");
        Console.WriteLine($"Valor do Produto: {this.preço}");
        Console.WriteLine($"Nome do Produto: {this.nome}");
        Console.WriteLine($"Descrição: {this.descrição}");
    }
}
}

