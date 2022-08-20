Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int cube = 1;
while (cube <= numberN)
{   
   int result = cube * cube * cube;
   Console.Write (" " + result);
     cube++;
 }