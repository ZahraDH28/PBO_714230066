namespace P2_1_714230066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukan angka pertama: ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukan angka kedua: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine($"{input1} + {input2} = {input1 + input2}");
            Console.WriteLine($"{input1} - {input2} = {input1 - input2}");
            Console.WriteLine($"{input1} * {input2} = {input1 * input2}");
            Console.WriteLine($"{input1} / {input2} = {input1 / input2}");


        }
    }
}
