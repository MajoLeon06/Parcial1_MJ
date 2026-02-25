Console.WriteLine("Ingrese el nombre del estudiante:");
string nombre = Console.ReadLine();
Console.WriteLine("Ingresar nota:");
double nota = double.Parse(Console.ReadLine());
if (nota>=70)
{
    Console.WriteLine($"{nombre}, Aprobado");
}
else
{
    Console.WriteLine($"{nombre}, Reprobado");
}