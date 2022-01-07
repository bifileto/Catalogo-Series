using System;

namespace DIO.Series
{

  public class Serie : EntidadeBase
  {
    //Atributos

    private Genero Genero {get; set;}

    private string Titulo {get; set;}

    private string Descricao {get; set;}

    private int Ano {get; set;}

    private bool Excluido {get;set;}
    //Metodos

    //Metodo de construtor
    public Serie (int id, Genero genero, string titulo, string descricao, int ano)
    {
      this.Id = id;
      this.Genero = genero;
      this.Titulo = titulo;
      this.Descricao = descricao;
      this.Ano = ano;
      this.Excluido = false;
    }

    //Implementacao do ToString

    public override string ToString()
    {
      //Estudar environment New Line no docs da microsoft - ele pega de acordo com sistema operacional pra descer a linha
      string retorno = "";
      retorno += "Gênero: " + this.Genero + Environment.NewLine;
      retorno += "Título: " + this.Titulo + Environment.NewLine;
      retorno += "Descrição: " + this.Descricao + Environment.NewLine;
      retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
      retorno += "Excluido: " + this.Excluido;
      return retorno;
    }

    //metodos de encapsulamento
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

    public void Excluir() 
    {
      this.Excluido = true;
    }
  }
}