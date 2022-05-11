namespace RoleplayGame
{
    public class Axe : IEquipment
    {
        /*
        Se agrega un valor de defensa 0 para poder implementar la interfaz equipamiento en todos los items.
        Esto hace que se puedan almacenar items tanto de armadura como de daño dentro del equipamiento
        de los personajes.
        */
        public int AttackValue 
        {
            get
            {
                return 25;
            } 
        }
        public int DefenseValue {get{return 0;}}
    }
}