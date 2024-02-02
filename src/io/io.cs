namespace IOModels
{
    class Input
    {
        public static int ReceiveNumber(string textToShow)
        {
            int result;
            string prompt;

            do
            {
                Console.WriteLine(textToShow);
                prompt = Console.ReadLine();

                if (!int.TryParse(prompt, out result))
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                }
            } while (!int.TryParse(prompt, out result));

            return result;
        }
        public static decimal ReceiveDecimal(string textToShow)
        {
            decimal result;
            string prompt;

            do
            {
                Console.WriteLine(textToShow);
                prompt = Console.ReadLine();

                if (!decimal.TryParse(prompt, out result))
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                }
            } while (!decimal.TryParse(prompt, out result));

            return result;
        }


        public static string ReciveText(string textToShow)
        {
            string promp;
            do
            {
                Console.WriteLine(textToShow);
                promp = Console.ReadLine();
                if (promp == null)
                {
                    Console.WriteLine("Por favor, digite algo diferente de nulo.");
                }
            } while (promp == null);

            return promp;
        }

        public static DateTime ReceiveDate(string textToShow)
        {
            string prompt;
            DateTime date;
            do
            {
                Console.WriteLine(textToShow);
                Console.Write("Digite uma data (formato YYYY-MM-DD): ");
                prompt = Console.ReadLine();

            } while (!DateTime.TryParse(prompt, out date));

            return date;
        }

        public static bool ReciveBoolOption(string textToShow)
        {
            string prompt;
            prompt = Console.ReadLine();
            List<string> options = new() { "sim", "s", "Sim", "SIM" };
            return options.Equals(prompt);
        }
    }
}