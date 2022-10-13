using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_C_.Models{
    public class Reserva{
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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (hospedes.Count<= Suite.Capacidade){
                Hospedes = hospedes;
            }else{
                 throw new ArgumentException("Não há mias lugares disponíveis na suíte");
            }
           
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            
            int quantidade = 0;
            quantidade += Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;


            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if(DiasReservados <=10){
                valor *= 0.90M;
            }

            return valor;
        }
    }
}