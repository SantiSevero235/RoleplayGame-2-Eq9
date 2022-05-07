using System;
using RoleplayGame;
/// <summary>
/// Al ver el codigo, para poder aplicar interfaces lo que hicimos fue refactorizarlo.
/// </summary>

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            Staff staff = new Staff();
            gandalf.Equip(staff);
            gandalf.EquipSpellbook(book);

            ICharacters gimli = new Dwarf("Gimli");
            Axe axe = new Axe();
            gimli.Equip(axe);
            Helmet helmet = new Helmet();
            gimli.Equip(helmet);
            Shield shield = new Shield();
            gimli.Equip(shield);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
