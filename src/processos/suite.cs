using IOModels;
using AppOptions;
using Logic;
namespace Processos
{
    public class PSuite
    {
        public static void Show()
        {
            Options.ListOptionsSuites();
            LSuite _suiteOptions = new();
            int selectOption = Input.ReceiveNumber("Opção entendida: ");
            switch (selectOption)
            {
                case 1:
                    _suiteOptions.CadastroSuite();
                    break;
                case 2:
                    _suiteOptions.ListarTodasAsSuites();
                    break;
                case 0:
                    break;
            }
        }
    }
}