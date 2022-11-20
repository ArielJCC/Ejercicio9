//Programa que lea una serie de números (leer hasta que llegue el cero, por ejemplo) y que calcule su media aritmética 
internal class Program
{
    private static void Main(string[] args)
    {
        double num = 1; double media = 0; int i = 0;
        while(num != 0)
        {
            Console.WriteLine("Digite un número");
            num = double.Parse(Console.ReadLine());

            i++;
            media = media + num;

        }
        Console.WriteLine("Finalizado");
        Console.WriteLine("La media aritmética de los números ingresados es: "+media / i);
           
    }
}