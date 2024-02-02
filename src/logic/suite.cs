using DesafioProjetoHospedagem.Models;
using IOModels;
using DataBaseAplication;

namespace Logic
{
    class LSuite
    {
        private readonly DataBase _db = DataBase.InstanciaUnica;

        public void CadastroSuite()
        {
            Console.Clear();
            string tipoSuite = Input.ReciveText("Qual é o tipo da suite: ");
            int capacidadeSuite = Input.ReceiveNumber("Qual é a capacidade: ");
            decimal valorDiaria = Input.ReceiveDecimal("Qual é o valor da diaria: ");
            Suite suite = new(tipoSuite, capacidadeSuite, valorDiaria);
            _db.Suite.Add(suite);
        }

        public void ListarTodasAsSuites()
        {
            Console.Clear();
            _db.Suite.ForEach((c) => Console.WriteLine(c.DescSuite));
        }

        public Suite GetSuiteById()
        {
            int findSuiteById = Input.ReceiveNumber("Digite o ID da suite: ");
            IEnumerable<Suite> suitEncontradas = _db.Suite.Where(s => s.Id == findSuiteById);
            Suite getSuite = suitEncontradas.FirstOrDefault();
            return getSuite;
        }
    }
}