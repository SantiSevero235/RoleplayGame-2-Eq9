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

        /*
        Se crea una lista de equipamiento con el objetivo de poder equipar en un personaje cualquier item del
        tipo IEquipment. El equipar los items utilizando atributos no es una buena idea, dado que los items
        pasan a ser parte de los personajes, y no se pueden ni añadir ni remover items sin modificar la clase.
        Por esta razon se utiliza una lista, y gracias a los tipos genericos se pueden añadir distintos items,
        siempre y cuando pertenezcan a IEquipment.
        */
        private List<IEquipment> equipment = new List<IEquipment>();

        public string Name { get; set; }

        private SpellsBook SpellsBook { get; set; }

        public int AttackValue
        {
            get
            {
                int attack = 0;
                if (this.SpellsBook != null)
                {
                    attack +=  SpellsBook.AttackValue;
                }
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
                int defense = 0;
                if (this.SpellsBook != null)
                {
                    defense +=  SpellsBook.DefenseValue;
                }
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
            if (this.SpellsBook == null)
            {
                this.SpellsBook = spellsBook;
            }
        }
    }
}