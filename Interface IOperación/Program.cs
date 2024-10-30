using Interface_IOperación;

Operacion operacion = new Operacion();

Console.WriteLine("Ingrese el primer numero");
operacion.N1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
operacion.N2 = Convert.ToDouble(Console.ReadLine());

operacion.Imprimir();