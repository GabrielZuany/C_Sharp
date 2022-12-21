using System;

class Program
{
    static void Main()
    {
        Conta conta1 = new Conta("Alexandre", "da Silva");
        Console.WriteLine(conta1.GetNome() + conta1.GetSobrenome());

        conta1.SetNome("Gabriel");
        conta1.SetSobrenome(" Zuany");
        Console.WriteLine(conta1.GetNome() + conta1.GetSobrenome());
        
    }

}

public class Conta
{
    private string Nome;
    private string Sobrenome;

    public Conta(string Nome, string Sobrenome)//contrutor = já instancia valores na criacao do objeto.
    {
        this.Nome = Nome;
        this.Sobrenome = Sobrenome;
    }

    //métodos GET/SET evitam que o usuário acesse diretamente variáveis da classe, desde que voce as instancie como private.
    public string GetNome()
    {
        return Nome;
    }
    public string GetSobrenome()
    {
        return Sobrenome;
    }
    public void SetNome(string Nome)
    {
        this.Nome = Nome;
    }
    public void SetSobrenome(string Sobrenome)
    {
        this.Sobrenome = Sobrenome;
    }

}