using System.Data.Common;
using DesafioProjetoHospedagem.Models;

namespace DataBaseAplication
{
    class DataBase
    {
        private static readonly DataBase instanciaUnica = new();
        private readonly List<Pessoa> clientes = new();
        private readonly List<Suite> suites = new();
        private readonly List<Reserva> reserva = new();
        public static DataBase InstanciaUnica { get => instanciaUnica; }
        public List<Pessoa> Clientes { get => clientes; }
        public List<Suite> Suite { get => suites; }
        public List<Reserva> Reserva { get => reserva; }

        public static void GenerateDatas()
        {
            DataBase db = DataBase.instanciaUnica;
            DateTime cpfData = DateTime.Now;
            CPF p1Cpf = new("111.111.111-11", cpfData);
            CPF p2Cpf = new("222.222.222-22", cpfData);
            db.clientes.Add(new Pessoa("Gabriel Souza", "Bicho Nunes", p1Cpf));
            db.clientes.Add(new Pessoa("Johnson", "& Johnson", p2Cpf));
            db.suites.Add(new Suite("Luxuosa", 4, 10.50M));
            db.suites.Add(new Suite("Mediana", 2, 5.50M));
            db.suites.Add(new Suite("Mediana", 1, 2.50M));
        }
    }
}