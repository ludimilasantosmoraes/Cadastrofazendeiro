public class Fazendeiro
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public static string Cpf { get; set; }

    public string Cnpj { get; set; }

    public double PropriedadeR { get; set; }

    public int CabecaG { get; set; }

    public Fazendeiro()
    {

    }
    public Fazendeiro(string nome, int idade, string cpf, string cnpj, double propiedadeR, int cabecaG)
    {
        this.Nome = nome;
        this.Idade = idade;
        Fazendeiro.Cpf = cpf;
        this.Cnpj = cnpj;
        this.PropriedadeR = propiedadeR;
        this.CabecaG = cabecaG;
        
    }

    public string MarcaGado(string nome)
    {
        string[] split = nome.Split(" ");
        string nome1 = split[0];
        string nome2 = split[1];

        string marca = (nome1[0] + nome2[0].ToString()).ToUpper();
        return marca;
    }
   
}