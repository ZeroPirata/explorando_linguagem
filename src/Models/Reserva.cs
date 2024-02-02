using DataBaseAplication;
using IOModels;
using Logic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados, Pessoa pesssoaQueReservou, Suite SuiteAlugada)
        {
            Hospedes = new List<Pessoa>
            {
                pesssoaQueReservou
            };
            Suite = SuiteAlugada;
            DiasReservados = diasReservados;
        }

    }
}