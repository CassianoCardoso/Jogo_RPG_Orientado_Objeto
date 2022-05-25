

namespace Jogo_RPG_Orientado_Objeto.src.Entities
{
  public class Wizard : Hero
  {


    public Wizard(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }
    public override string Attack()
    {
      return this.Name + "Lançou magia";
    }

    public string Attack(int Bonus)
    {
      if (Bonus > 6)
      {
        return this.Name + "Lançou com bonus de magis de  atack" + Bonus;
      }
      else
      {
        return this.Name + "Lançou magia fraca " + Bonus;
      }

    }
  }
}