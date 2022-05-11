using System.Collections.Generic;

namespace RoleplayGame
{
    /// <summary>
    /// No se agrega a la interfaz de IEquipment porque tomando en cuenta las historias de usuario no deberia poder
    /// ser utilizado por otras clases que no sean el mago. Si se implementara la interface en esta clase,
    /// sería posible almacenar libros de hechizos en el equipamiento de un personaje que no sea el mago,
    /// dado que son listas de IEquipment, pero como se dice que el libro de hechizos es el conocimiento
    /// del mago, no se debe poder almacenar un libro en un personaje distinto.
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