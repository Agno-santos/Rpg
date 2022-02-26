namespace Rpg
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Attack(){
            return this.Name + " lançou 3 shurikens ";
        }
        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                 return this.Name + " soltou um golpe especial shinku hadouken com bonus de " + Bonus;
            }else
            {
                 return this.Name + " lancou uma magia simples hadouken com bonus de " + Bonus;
            }
            
            
        }

        
    }
}