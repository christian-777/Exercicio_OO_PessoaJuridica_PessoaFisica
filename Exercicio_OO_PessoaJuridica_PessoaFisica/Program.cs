using Exercicio_OO_PessoaJuridica_PessoaFisica;

internal class Program
{
    private static void Main(string[] args)
    {
        PhysicalPerson physicalPerson = new PhysicalPerson();

        physicalPerson.Name = "Christian";
        physicalPerson.Adress = "Rua dos Bobos, 0";
        physicalPerson.Email = "juninho_do_pneu@email.com";
        physicalPerson.Phone1 = "(99) 99999-9999";
        physicalPerson.Phone2 = "(11) 11111-1111";
        physicalPerson.Cpf = "000.000.000-00";


        LegalEntity legalEntity = new LegalEntity();

        legalEntity.Name = "Jorel";
        legalEntity.Adress = "Av. sei la";
        legalEntity.Email = "chaolin_matador_de_porco@email.com";
        legalEntity.Phone1 = "(88) 8888-8888";
        legalEntity.Phone2 = "(22) 22222=2222";
        legalEntity.Cnpj = "111.111.111.111";
        legalEntity.FantasyName = "Jorel LTDA";


        Console.WriteLine(physicalPerson.ToString());
        Console.WriteLine(legalEntity.ToString());
    }
}