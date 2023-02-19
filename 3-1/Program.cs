Console.Clear();
int[] array = { 1, 1, 1, 1, 0 };
bool num = true;
int i = 0;
int j = array.Length - 1;
Console.Write("число является палиндромом: ");
while (i <= j)
{
  if (array[i] == array[j])
  {
    i++;
    j--;
  }
  else
  {
    num = !num;
    break;
  }
}
Console.WriteLine(num);