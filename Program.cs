// Задайте массив сисволов (тип char []. Создайте сроку из символов этого массива)

using System.Runtime.ExceptionServices;

char[] array = new char[] { '1', '3', 'y', '3', 'h' };

string str = "";
for (int i = 0; i < array.Length; i++)
{
 str += array[i];
}
System.Console.WriteLine(str);