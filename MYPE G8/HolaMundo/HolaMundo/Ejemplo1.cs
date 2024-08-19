namespace HolaMundo
{
    internal class Ejemplo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Inti Montalvan");
            //Tipos de datos primitvos
            int edad = 17;
            Console.WriteLine($"Tu edad es: {edad}");
            string nombre = "Inti Montalvan";
            Console.WriteLine($"Tu nombre es: {nombre}");
            Console.WriteLine($"Tu nombre es: {nombre.ToUpper()}");
            Console.WriteLine($"Tu nombre es: {nombre.ToLower()}");

            //Length permite saber el numero de caracteres de la variable
            Console.WriteLine($"Cauntas letras tiene tu nombre: {nombre.Length} letras");

            //Variables de doble precision
            double precio = 12.99;
            Console.WriteLine($"El precio es de: {precio}");
            Console.WriteLine($"El precio es de: {precio++}");
            Console.WriteLine($"El precio es de: {++precio}");

            /* Valores Logicos */
            bool isSingle = true;
            Console.WriteLine($"Tu eres soltero: {isSingle}");
            Console.WriteLine($"Tu eres soltero: {!isSingle}");
            Console.WriteLine($"Tu eres soltero: {isSingle}");

        }
    }
}