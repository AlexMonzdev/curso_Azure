
using POO_Ejemplo_2;

main();
void main()
{
    Cliente cliente1 = new Cliente();
    cliente1.ID= 1;
    cliente1.Nombre = "Juan";
    cliente1.Apellido = "lopez";

    Cliente cliente2 = new Cliente();
    cliente2.ID = 2;
    cliente2.Nombre = "Ana";
    cliente2.Apellido = "Peralta";

    ActividadesDelCLiente actividadesDelCLiente = new ActividadesDelCLiente();
    actividadesDelCLiente.AltaDeCliente(cliente1);
    actividadesDelCLiente.AltaDeCliente(cliente2);
}
