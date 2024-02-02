namespace DesafioProjetoHospedagem.Models;

public class CPF
{
    private string _value { get; set; }
    private DateTime _emited { get; set; }

    public string LeituraDoCpf => $"Valor: {_value}, Data de emissão: {_emited}";

    public string Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public DateTime Emited
    {
        get { return _emited; }
        set { _emited = value; }
    }

    public CPF(string value, DateTime emited)
    {
        _value = value;
        _emited = emited;
    }
    
}