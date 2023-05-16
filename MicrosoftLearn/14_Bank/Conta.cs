
public class Conta
{
    private string Nome;
    private string Sobrenome;
    private double Saldo;
    private string NumeroDaConta;

    public Conta(string Nome, string Sobrenome, double Saldo, string NumeroDaConta)//contrutor = já instancia valores na criacao do objeto.
    {
        this.Nome = Nome;
        this.Sobrenome = Sobrenome;
        this.Saldo = Saldo;
        this.NumeroDaConta = NumeroDaConta;
    }

    //métodos GET/SET evitam que o usuário acesse diretamente variáveis da classe, desde que voce as instancie como private.
    public Conta GetDados()
    {
        Conta c = new Conta(Nome, Sobrenome, Saldo, NumeroDaConta);
        return c;
    }
    public string GetNome()
    {
        return Nome;
    }
    public string GetSobrenome()
    {
        return Sobrenome;
    }
    public double GetSaldo()
    {
        return Saldo;
    }
    public void SetNome(string Nome)
    {
        this.Nome = Nome;
    }
    public void SetSobrenome(string Sobrenome)
    {
        this.Sobrenome = Sobrenome;
    }
    public void SetSaldo(double Saldo)
    {
        this.Saldo = Saldo;
    }
    public void AumentaSaldo(double valor)
    {
        Saldo+=valor;
    }

}