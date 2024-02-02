namespace AppOptions
{
    public class Options
    {
        public static void ListOptions()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Menu Clientes");
            Console.WriteLine("2. Menu Suites.");
            Console.WriteLine("3. Menu Reservas.");
            Console.WriteLine("---------------------------------");
        }
        public static void ListOptionsCliente()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Cadastrar Cliente.");
            Console.WriteLine("2. Remover Cliente.");
            Console.WriteLine("3. Listar Todos os clientes.");
            Console.WriteLine("---------------------------------");
        }
        public static void ListOptionsSuites()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Cadastrar nova Suite.");
            Console.WriteLine("2. Listar Suites.");
            Console.WriteLine("---------------------------------");
        }
        public static void ListOptionsReservas()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Vincular Hospede.");
            Console.WriteLine("2. Obter quantida de hospedes.");
            Console.WriteLine("3. Mostrar valores das diarias dos hospedes.");
            Console.WriteLine("---------------------------------");
        }
    }
}