namespace RoleplayGame
{
    public class Armor : IEquipment
    {
        /*
        Se agrega un valor de ataque 0 para poder implementar la interfaz equipamiento en todos los items.
        Esto hace que se puedan almacenar items tanto de armadura como de daño dentro del equipamiento
        de los personajes.
        */
        
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