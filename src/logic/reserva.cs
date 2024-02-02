using DataBaseAplication;
using DesafioProjetoHospedagem.Models;
using IOModels;

namespace Logic
{
    class LReserva
    {
        private readonly DataBase _db = DataBase.InstanciaUnica;
        private readonly LCliente _lc = new();
        private readonly LSuite _ls = new();
        public void CadastrarHospedes()
        {
            Pessoa cliente = _lc.GetClienteByCpf();
            Suite suite = _ls.GetSuiteById();
            int quantidadeDeConvidade = Input.ReceiveNumber("Quantos clientes estão acompanhando?: ") + 1;
            if (!(suite.Capacidade >= quantidadeDeConvidade)) Console.WriteLine("A capacidade da suite é menor a quantidade de hóspedes.");
            else
            {
                int quantidadeDeDias = Input.ReceiveNumber("Qunatos dias eles vão ficar?: ");
                Reserva suiteEscolhida = new(quantidadeDeDias, cliente, suite);
                _db.Reserva.Add(suiteEscolhida);
            }
        }

        public int ObterQuantidadeHospedes()
        {
            return _db.Reserva.Count;
        }

        public void CalcularValorDiaria()
        {
            Console.Clear();
            int index = 0;
            _db.Reserva.ForEach(r =>
            {
                decimal valor = 0;
                valor = r.DiasReservados * r.Suite.ValorDiaria;
                if (r.DiasReservados >= 10) valor -= valor * 0.1m;
                Console.WriteLine($"Cliente: {r.Hospedes[index].NomeCompleto}, Valor total a pagar: {valor:C}");
                index++;
            });
        }
    }
}