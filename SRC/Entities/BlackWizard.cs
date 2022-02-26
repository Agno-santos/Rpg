namespace Rpg
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Attack(){
            return this.Name + " lançou magia Negra ";
        }
        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
            return this.Name + " lançou magia negra super efetiva com bonus de " + Bonus;
            }else
            {
                return this.Name + " lancou uma magia com força fraca com bonus de " + Bonus;
            }
            
            
        }
        
    }
}