namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {       
            if (suite >= Hospedes)
            {
                Console.WriteLine("Capacidade suficiente para os hóspedes.");
            }
            else
            {
                Console.WriteLine("Capacidade insuficiente! Reduza o número de hóspedes ou aumente a capacidade.");
            }

            if (true)
            {
                Hospedes = hospedes;
            }
            else
            {             
                if (hospedes.Count > Suite.Capacidade)
                {
                    throw new InvalidOperationException("Capacidade insuficiente para o número de hóspedes.");

                }
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {           
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
           
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                decimal desconto = Convert.ToDecimal(valor * 10 / 100);
                return valor - desconto;
            }

            return valor;
        }
    }
}