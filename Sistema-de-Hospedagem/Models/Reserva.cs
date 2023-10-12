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
             if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Capacidade de hóspedes excedida.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            if (Hospedes != null)
            {
                return Hospedes.Count;
            }
            return 0;
        }


        public decimal CalcularValorDiaria()
        {
            if (DiasReservados >= 10)
            {
                decimal valorComDesconto = DiasReservados * Suite.ValorDiaria * 0.9M; // 10% discount
                return valorComDesconto;
            }
            else
            {
                return DiasReservados * Suite.ValorDiaria;
            }
        }

    }
}