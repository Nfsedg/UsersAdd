using System;
namespace POO2.Clases
{
	public class Operaciones
	{
		public void Suma ()
		{
			Console.WriteLine("Dame cuantos números vas a sumar");

			int quantityOfNumber = int.Parse(Console.ReadLine());
			int counter = 0;

			for(int i = 0; i < quantityOfNumber; i++)
			{
				Console.WriteLine("Dame el número" + (i+1));
				int currentNumber = int.Parse(Console.ReadLine());
				counter += currentNumber;
			}

			Console.WriteLine("El total es " + counter);
		}
        public void Resta()
        {
            Console.WriteLine("Dame cuantos números vas a sumar");

            int quantityOfNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < quantityOfNumber; i++)
            {
                Console.WriteLine("Dame el número" + (i+1));
                int currentNumber = int.Parse(Console.ReadLine());
                if(i == 0)
                {
                    counter = currentNumber;
                } else
                {
                    counter -= currentNumber;
                }
            }

            Console.WriteLine("El total es " + counter);
        }
        public void Multi()
        {
            Console.WriteLine("Dame cuantos números vas a sumar");

            int quantityOfNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < quantityOfNumber; i++)
            {
                Console.WriteLine("Dame el número" + (i+1));
                int currentNumber = int.Parse(Console.ReadLine());
                counter *= currentNumber;
            }

            Console.WriteLine("El total es " + counter);
        }
        public void PesoToDollar()
        {
            int CostDollar = 18;
            Console.WriteLine("Dame la cantidad de dolares a cambiar");
            int pesos = int.Parse(Console.ReadLine());
            int result = pesos * CostDollar;

            Console.Clear();
            Console.WriteLine("El total en pesos es " + result);

        }
        //public void DollarToPeso() {
        //     CostPeso = 0.55;
        //    Console.WriteLine("Dame la cantidad de dolares");
        //    int dolar = int.Parse(Console.ReadLine());


        //}
    }
}

