using DataBaseAplication;

namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        private DataBase _db = DataBase.InstanciaUnica;

        public Suite() { }
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            Id = _db.Suite.Count + 1;
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public int Id { get; }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
        public string DescSuite => $"Tipo: {TipoSuite}, Valor da Diaria: {ValorDiaria}, Capacidade Total: {Capacidade}";
    }
}