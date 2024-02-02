using AppOptions;
using DataBaseAplication;
using DesafioProjetoHospedagem.Models;
using IOModels;
using Processos;

namespace Aplicativo
{
    class Executavel
    {
        public Executavel()
        {
            DataBase.GenerateDatas();
            Console.WriteLine($"Bem-vindo");
            bool start = true;
            do
            {
                Options.ListOptions();
                int select = Input.ReceiveNumber("Opção entendida: ");
                switch (select)
                {
                    case 1:
                        PCliente.Show();
                        break;
                    case 2:
                        PSuite.Show();
                        break;
                    case 3:
                        PReserva.Show();
                        break;
                    case 0:
                        Console.WriteLine("Fechando aplicação");
                        start = false;
                        break;
                }
            } while (start);
        }
    }
}