

namespace Jogo_RPG_Orientado_Objeto.src.Entities
{
  public abstract class Hero
  {
    //Construtor 
    public Hero(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }

    public string Name;
    public int Level ;
    public string HeroType;


    //Metodos
    public override string ToString()
    {
      return this.Name + " " + this.Level + " " + this.HeroType;
    }
    public virtual string Attack()
    {
        return this.Name + "Atacou com sua espada";
    }
  }
}