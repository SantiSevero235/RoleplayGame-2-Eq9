namespace RoleplayGame
{
    public interface ICharacters
    {
        void ReceiveAttack(int power);
        void Cure();
        void Equip(IEquipment equip);
        void Unequip(IEquipment equip);
    }
}