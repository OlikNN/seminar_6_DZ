// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

List<int> integer = new List<int>();

string str = "";
int i = 0;
int j = 0;
int count = 0;

while (str != "stop")
{
    i++;
    Console.WriteLine($"Введите число {i}");
    str = Console.ReadLine();

    if (str != "stop")
    {
        integer.Add(Convert.ToInt32(str));
    }
}

int[] integerArray = integer.ToArray();

while (j < integerArray.Length)
{
    Console.WriteLine($"число {integerArray[j]}");

    if (integerArray[j] > 0)
    {
        count++;
    }
    j++;

}

Console.WriteLine($"{count} раз пользователь ввел число больше нуля");