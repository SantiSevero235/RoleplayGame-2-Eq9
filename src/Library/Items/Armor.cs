namespace RoleplayGame
{
    public class Armor : IEquipment
    {
        public int AttackValue {get{return 0;}}
        public int DefenseValue
        {
            get
            {
                return 25;
            }
        }
    }
}