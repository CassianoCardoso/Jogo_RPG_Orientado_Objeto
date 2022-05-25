
using Jogo_RPG_Orientado_Objeto.src.Entities;

namespace Jogo_RPG_Orientado_Objeto
{

  class Program
  {

    static void Main(string[] args)
    {
      Knight arus = new Knight("Arus", 23, "knight");
      Wizard wizard = new Wizard("Jennica", 30, "White Wizard");

      //System.Console.WriteLine(arus.Attack());
      System.Console.WriteLine(wizard.Attack());
    }


  }

}
