using Arreglos.Logica;

Console.WriteLine("Operaciones de pila");

Console.WriteLine("Arreglo\n");
MiArreglo oMiArreglo = new MiArreglo(10);
oMiArreglo.Llenar(1, 20);

Console.WriteLine("Arreglo desordenado\n");
Console.WriteLine(oMiArreglo);

Console.WriteLine("Arreglo ordenado ascendente\n");
oMiArreglo.Ordenar();
Console.WriteLine(oMiArreglo);

Console.WriteLine("Arreglo ordenado descendente\n");
oMiArreglo.Ordenar(false);
Console.WriteLine(oMiArreglo);




Console.ReadKey();
