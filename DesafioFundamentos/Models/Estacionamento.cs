namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:"); 
            //IMPLEMENTADO
            string placa = Console.ReadLine(); 
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            //IMPLEMNETADO
            string placa = Console.ReadLine(); 
            Console.WriteLine("Digite quantas horas o veículo ficou estacionado:");
            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                if (int.TryParse(Console.ReadLine(), out int horas))
            {
             
            //IMPLEMENTADO
            decimal valorTotal = precoInicial + (precoPorHora * horas);

            veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
           }
            else
            {
            Console.WriteLine("Entrada inválida para a quantidade de horas.");
            }
    }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
        
            if (veiculos.Any())
            {
                //IMPLEMENTADO
                Console.WriteLine("Os veículos estacionados são:"); 
                int j=0;
                foreach(string item in veiculos)
                { 
                Console.WriteLine($"Veículo Nº{j+1} - {item}"); 
                j++;
                }
               
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
