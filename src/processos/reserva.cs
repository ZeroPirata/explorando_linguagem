using IOModels;
using AppOptions;
using Logic;
namespace Processos
{
    public class PReserva
    {
        public static void Show()
        {
            Options.ListOptionsReservas();
            LReserva _reserevaOptions = new();
            int selectOption = Input.ReceiveNumber("Opção entendida: ");
            switch (selectOption)
            {
                case 1:
                    _reserevaOptions.CadastrarHospedes();
                    break;
                case 2:
                    _reserevaOptions.ObterQuantidadeHospedes();
                    break;
                case 3:
                    _reserevaOptions.CalcularValorDiaria();
                    break;
                case 0:
                    break;
            }
        }
    }
}