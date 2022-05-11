namespace RoleplayGame
{
    public class Spell
    {
        /*
        En esta clase no se implementa la interface porque los hechizos no son items en si mismos,
        el item es el libro de hechizos.
        */
        public int AttackValue
        {
            get
            {
                return 70;
            }
        }

        public int DefenseValue
        {
            get
            {
                return 70;
            }
        }
    }
}