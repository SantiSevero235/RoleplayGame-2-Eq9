using System.Collections.Generic;

namespace RoleplayGame
{
    /// <summary>
    /// No se agrega a la interfaz de IEquipment porque tomando en cuenta las historias de usuario no deberia poder
    /// ser utilizado por otras clases que no sean el mago.
    /// </summary>
    public class SpellsBook
    {
        public Spell[] Spells { get; set; }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }
    }
}