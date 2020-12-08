namespace heranca.classes
{
    public class Pessoa
    {

        //A herança é um princípio próprio à programação orientada a objetos (POO) que permite criar uma nova classe a partir de uma já existente. O nome herança, também chamada de subclasses, provém do fato de que a subclasse (a classe recém-criada) contém atributos e métodos da classe primária (da qual deriva). A principal vantagem da herança é a capacidade para definir novos atributos e métodos para a subclasse, que se somam aos atributos e métodos herdados.
        
        public string nome; //por enquanto não deixar private.

        public string DarBoasVindas(string nomeUsuario){
            return "Seja Bem vindo(a) ao nosso sistema, "+nomeUsuario;
        }
    }
}