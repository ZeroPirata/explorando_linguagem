using DesafioProjetoHospedagem.Models;
using IOModels;
using DataBaseAplication;

namespace Logic
{
    class LCliente
    {
        private readonly DataBase _db = DataBase.InstanciaUnica;

        public void CadastroCliente()
        {
            Console.Clear();
            string nome = Input.ReciveText("Digite seu nome");
            string sobreNome = Input.ReciveText("Digite seu SobreNome");
            string cpfValue = Input.ReciveText("Digite os numeros do seu CPF");
            DateTime cpfEmited = Input.ReceiveDate("Digite a data de emissão dele");
            CPF cpfCadastrado = new(cpfValue, cpfEmited);
            Pessoa pessoa = new(nome, sobreNome, cpfCadastrado);
            _db.Clientes.Add(pessoa);
        }

        public void RemoverCliente()
        {
            Console.Clear();
            LCliente cpfsCadastrados = new();
            cpfsCadastrados.ListarTodosOsCliente();
            string findClienteByCpf = Input.ReciveText("Digite o numero do CPF: ");
            IEnumerable<Pessoa> clientesEncontrados = _db.Clientes.Where(c => c.Cpf?.Value == findClienteByCpf);
            Pessoa getCliente = clientesEncontrados.FirstOrDefault();
            bool deleteOption = Input.ReciveBoolOption("Deseja deletar o cliente?: ");
            if (!deleteOption) return;
            _db.Clientes.Remove(getCliente);
        }
        public void ListarTodosOsCliente()
        {
            Console.Clear();
            _db.Clientes.ForEach((c) => Console.WriteLine($"Cliente: {c.NomeCompleto} \n{c.Cpf.LeituraDoCpf}"));
        }

        public Pessoa GetClienteByCpf()
        {
            LCliente cpfsCadastrados = new();
            cpfsCadastrados.ListarTodosOsCliente();
            string findClienteByCpf = Input.ReciveText("Digite o numero do CPF: ");
            IEnumerable<Pessoa> clientesEncontrados = _db.Clientes.Where(c => c.Cpf?.Value == findClienteByCpf);
            Pessoa getCliente = clientesEncontrados.FirstOrDefault();
            return getCliente;
        }
    }
}