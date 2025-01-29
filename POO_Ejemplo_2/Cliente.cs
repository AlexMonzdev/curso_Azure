using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejemplo_2
{
    //  Entidad
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }

    public class ActividadesDelCLiente
    {
        List<Cliente> BaseDeDatos = new List<Cliente>();

        public bool AltaDeCliente(Cliente cliente)
        {
            bool estado = false;

            if(cliente != null)
            {
                BaseDeDatos.Add(cliente);
                estado = true;
            }
            return estado;
        }
    }
}
