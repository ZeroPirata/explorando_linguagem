using IOModels;
using AppOptions;
using Logic;
namespace Processos
{
    public class PCliente
    {
        public static void Show()
        {
            Options.ListOptionsCliente();
            LCliente _clienteOptions = new();
            int selectOption = Input.ReceiveNumber("Opção entendida: ");
            switch (selectOption)
            {
                case 1:
                    _clienteOptions.CadastroCliente();
                    break;
                case 2:
                    _clienteOptions.RemoverCliente();
                    break;
                case 3:
                    _clienteOptions.ListarTodosOsCliente();
                    break;
                case 0:
                    break;
            }
        }
    }
}