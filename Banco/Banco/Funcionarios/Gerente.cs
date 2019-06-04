namespace ByteBank.Modelos.Funcionarios
{
    public class Gerente : FuncionarioAutenticavel
    {
        public Gerente(string cpf) : base(4000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
