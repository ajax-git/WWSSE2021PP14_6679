/*
    Napisz program czytający ze standardowego wejścia kolejne liczby całkowite i oblicza wartość sumy 
    i średniej arytmetycznej na standardowym wyjściu.
*/

int number, sum = 0;
Console.Write("Wprowadź n: ");
number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    sum += i;
}
Console.WriteLine("Suma liczb wynosi: {0}.", sum);
Console.WriteLine("Średnia arytmetyczna wynosi: {0}.", sum/number);