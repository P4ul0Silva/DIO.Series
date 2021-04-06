// É a classe onde as series são compostas de seus dados
// 
// 
// 
// 
// 
// 
using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase  // classe "Serie" herda da classe "EntidadeBase"
    {
        //Atributos
     private Genero Genero { get; set ; }   //usado um arquivo enum com os gêneros, cada um contendo um numero.
     private string Titulo { get; set ; }
        public Serie(string descricao, bool excluido) 
        {
            this.Descricao = descricao;
                this.Excluido = excluido;
               
        }
             private string Descricao { get; set; }
     private int Ano { get ; set ;}  
     private bool Excluido { get; set; } 

     public Serie(int id, Genero genero, string titulo, string descricao, int ano) // Construtor
     {

         //Métodos

         this.Id = id;// a referencia de id esta na declaração da classe, que referencia a clase abstrata "EntidadeBase"
         this.Genero = genero;
         this.Titulo = titulo;
         this.Descricao = descricao;
         this.Ano = ano;
         this.Excluido = false;
     }

    public override string ToString() // Sobreescreve o método ToString converte e executa as ações. 
    {
        string retorno = "";
        retorno += "Gênero: " + this.Genero + Environment.NewLine;
        retorno += "Titulo: " + this.Titulo + Environment.NewLine;
        retorno += "Descrição: " + this.Descricao + Environment.NewLine;
        retorno += "Ano de Início: " + this.Ano;
        retorno += "Excluido: " + this.Excluido;
        return retorno;
    }

    //Encapsulamento abaixo, poupa alteraçoes no método principal (pelo oq  entendi...)

    public string retornaTitulo() 
    {
        return this.Titulo;
    }


    public int retornaId()
    {
        return this.Id;
    }

    public bool retornaExcluido()
    {
        return this.Excluido;
    }

    public void Excluir() {
        this.Excluido = true;
    }

}

}

