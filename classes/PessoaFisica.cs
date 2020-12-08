namespace heranca.classes
{
    public class PessoaFisica : Pessoa //NOME DA CLASSE HERDADA
    {
        public string cpf;
        public string rg;
        public bool ValidarCpf(string documento){

            //DarBoasVindas("Joyce"); //acessando a herança

            if(documento != ""){
                return true;
            }

            return false;
        }
    }
}