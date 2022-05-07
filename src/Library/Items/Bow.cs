namespace RoleplayGame
{
    public class Bow : IEquipment
    {
        public int AttackValue 
        {
            get
            {
                return 15;
            } 
        }
        public int DefenseValue {get{return 0;}}
    }
}