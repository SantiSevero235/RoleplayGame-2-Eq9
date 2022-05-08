using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard : ICharacters
    {
        private int health = 100;

        public Wizard(string name)
        {
            this.Name = name;
        }
        private List<IEquipment> equipment = new List<IEquipment>();

        public string Name { get; set; }

        private SpellsBook SpellsBook { get; set; }

        public int AttackValue
        {
            get
            {
                int attack =  SpellsBook.AttackValue;
                foreach (IEquipment equip in this.equipment)
                {
                    attack += equip.AttackValue;
                }
                return attack;
            }
        }

        public int DefenseValue
        {
            get
            {
                int defense =  SpellsBook.DefenseValue;
                foreach (IEquipment equip in this.equipment)
                {
                    defense += equip.DefenseValue;
                }
                return defense;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }
        public void Equip(IEquipment equip)
        {
            this.equipment.Add(equip);
        }
        public void Unequip(IEquipment equip)
        {
            this.equipment.Remove(equip);
        }
        public void EquipSpellbook(SpellsBook spellsBook)
        {
            if (spellsBook != null)
            {
                this.SpellsBook = spellsBook;
            }
        }
    }
}