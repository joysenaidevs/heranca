using System;
using heranca.classes;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instaciamos nossa subclasse

            PessoaFisica pf = new PessoaFisica();
            PessoaJuridica pj = new PessoaJuridica();

            //atribuimos um valor para a propiedade disponivel na superclasse

            Console.WriteLine("Digite seu nome");
            pf.nome = Console.ReadLine();
            Console.WriteLine("Digite seu CPF");
            pf.cpf = Console.ReadLine();
            Console.WriteLine("Valide seu CNPJ");
            pj.cnpj = Console.ReadLine();
            

            //Mostramos no console um metodo de saudação

            Console.WriteLine( pf.DarBoasVindas(pf.nome) );

            Console.WriteLine(pf.ValidarCpf(pf.cpf) );

            Console.WriteLine(pj.ValidarCNPJ(pj.cnpj) );


        }
    }
}
