namespace RoleplayGame
{
    public class Sword : IEquipment
    {
        public int AttackValue 
        {
            get
            {
                return 20;
            } 
        }
        public int DefenseValue {get{return 0;}}
    }
}