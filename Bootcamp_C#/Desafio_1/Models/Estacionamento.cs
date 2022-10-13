namespace DesafioFundamentos.Models{
    public class Estacionamento{
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(){

        }

        public void inicio(){
            Console.Clear();
            bool exibirInicio = true;
            while(exibirInicio){
                Console.WriteLine("Selecione o tipo de veículo:\n1 - Carro\n2 - Moto\n3 - Ônibus/Caminhão");
                decimal veiculo = Convert.ToDecimal(Console.ReadLine());

                switch(veiculo){
                    case 1: precoPorHora = 5;
                            exibirInicio = false;
                            break;
                    case 2: precoPorHora = 4;
                            exibirInicio = false;
                            break;
                    case 3: precoPorHora = 6;
                            exibirInicio = false;
                            break;
                    default: Console.WriteLine("Selecione ma opção correta!!!");
                            break;
                }
            }  
        }

        public void AdicionarVeiculo(){
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Convert.ToString(Console.ReadLine()).ToUpper();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo(){
            Console.WriteLine("Digite a placa do veículo para remover:");
             string placa = Convert.ToString(Console.ReadLine()).ToUpper();
            if(veiculos.Count == 0){
                Console.WriteLine("Não há veículos no estacionamento");
            }else if (veiculos.Count > 0){
               Console.WriteLine("Digite quantas horas você ficou"); 
               decimal horas = Convert.ToDecimal(Console.ReadLine());
               Console.WriteLine($"Você deve pagar {horas * precoPorHora}");
               veiculos.Remove(placa);
            }
            else{
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        public void ListarVeiculos(){
            if (veiculos.Any()){
                Console.WriteLine("Os veículos estacionados são:");
               for(int i =0; i < veiculos.Count; i++){
                Console.WriteLine(veiculos[i]+ "\n");
               }
            }
            else if (veiculos.Count == 0){
                Console.WriteLine("Não há veículos estacionados.");
            }else{
                Console.WriteLine("Verifque de novo");    
            }
        }
    }
}
