namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, string sobrenome, CPF cpf)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        CpfPessoa = cpf;
    }
    private readonly CPF CpfPessoa;
    public CPF Cpf { get => CpfPessoa; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}