using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_hospedagem.Modelos
{
    public class Reserva
    {
        public List<Pessoa> Hospedes {get;set;}
        public Suite Suite {get;set;}
        public int DiasReservados{get;set;}

        public Reserva(){}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(Suite.Capacidade >= hospedes.Count){
                Hospedes = hospedes;
            }else{
                Console.WriteLine("A suíte não tem capacidade para hospedar esses hóspedes!");
            }
        }

        public void CadadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        
        public int ObterQuantidadeHospedes()
        {
            int quantidade = Hospedes.Count;

            return quantidade;
            
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if(DiasReservados >= 10 ){
                
                decimal valorFinal = valor - (10/100);
            }

            return valor;
        }
    }
}