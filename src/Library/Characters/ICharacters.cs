namespace RoleplayGame
{
    public interface ICharacters
    {
        void ReceiveAttack(int power);
        void Cure();
        void Equip(IEquipment equip);
        void Unequip(IEquipment equip);
        int AttackValue{get;}
        int DefenseValue{get;}
        string Name{get;}
        int Health{get;}
    }
}