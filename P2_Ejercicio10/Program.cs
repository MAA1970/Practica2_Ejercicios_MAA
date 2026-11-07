namespace P2_Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== EJERCICIO 10 ===");
            
            Console.WriteLine("=== CALCULADORA DE ÁREAS GEOMÉTRICAS ===");

            // --- 1. Rectángulo ---
            Console.WriteLine("\n--- Rectángulo ---");
            Console.Write("Ingresa la base del rectángulo: ");
            double baseRect = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la altura del rectángulo: ");
            double alturaRect = Convert.ToDouble(Console.ReadLine());

            IForma rectangulo = new Rectangulo(baseRect, alturaRect);
            Console.WriteLine($"-> El área del Rectángulo es: {rectangulo.area}");

            // --- 2. Círculo ---
            Console.WriteLine("\n--- Círculo ---");
            Console.Write("Ingresa el radio del círculo: ");
            double radioCirculo = Convert.ToDouble(Console.ReadLine());

            IForma circulo = new Circulo(radioCirculo);
            Console.WriteLine($"-> El área del Círculo es: {circulo.area:F2}");

            // --- 3. Triángulo ---
            Console.WriteLine("\n--- Triángulo ---");
            Console.Write("Ingresa la base del triángulo: ");
            double baseTriang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la altura del triángulo: ");
            double alturaTriang = Convert.ToDouble(Console.ReadLine());

            IForma triangulo = new Triangulo(baseTriang, alturaTriang);
            Console.WriteLine($"-> El área del Triángulo es: {triangulo.area}");

          
        }



    }
}
