// //Программа, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

int maxSize = 3; // максимальное количество символов в элементах массива для выборки
Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] oldArray = new string [m];
void array(string [] Arr) //метод ввода элементов массива
{
  for (int i = 0;i<m;i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     Arr[i] = Console.ReadLine()?? "";
  }
}
int TwoArraySize(string [] Arr) //метод определения нового размера массива
{
  int n = 0;
  for (int i = 0;i<m;i++)
  {
    if(oldArray[i].Length <= maxSize)
    n++;
  }
  return n;
}
string [] TwoArray(string [] arr) //метод присваивания значений элементов нового массива
{
  string [] newArr = new string [TwoArraySize(oldArray)];
  int j = 0;
  for (int i = 0;i<m;i++)
  {
    if(oldArray[i].Length <=maxSize)
    {
        newArr[j] = oldArray[i];
        j++;
    }
  }
  return newArr;
}
void printArr(string [] Array) //метод печати массива
{
    int arrLeng = Array.Length;
    Console.Write("[");
    for (int i = 0;i<arrLeng;i++)
    {
    Console.Write($"{Array[i]} ");
    }
    Console.Write("]");
}
array(oldArray);
printArr(oldArray);
string[] newArr = TwoArray(oldArray);
printArr(newArr);
