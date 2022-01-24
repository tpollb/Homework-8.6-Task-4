using Homework_8._6_Task_4;

double PhoneNumberCheck(string str)
{

    string str_rem_spaces = str.Replace(" ", "");

    bool flag = double.TryParse(str_rem_spaces, out double result);
    int len = str_rem_spaces.Length;

    char first = str_rem_spaces[0];

    if (flag == false || len != 11 || first != '8')
    {
        return 0;
    }
    else
    {
        return result;
    }
}

bool flag = false;
string fio;
string street;
int housenumber = 0;
int flatnumber = 0;
double mobilephone = 1;
double flatphone = 1;
string input;

Console.WriteLine("Задание 4. Записная книжка");
Console.WriteLine("Введите фио:");
fio = Console.ReadLine();

Console.WriteLine("Введите улицу:");
street = Console.ReadLine();


while (flag == false)
{
    Console.WriteLine("Введите номер дома:");
    input = Console.ReadLine();
    flag = int.TryParse(input, out housenumber);
}

flag = false;

while (flag == false)
{
    Console.WriteLine("Введите номер квартиры:");
    input = Console.ReadLine();
    flag = int.TryParse(input, out flatnumber);
}

Console.WriteLine("Введите номер мобильного телефона (81234567890)");
input = Console.ReadLine();

while (PhoneNumberCheck(input) == 0)
{
    Console.WriteLine("Введите номер мобильного телефона (81234567890)");
    input = Console.ReadLine();
    Console.WriteLine($"{mobilephone}");
}
mobilephone = PhoneNumberCheck(input);

Console.WriteLine("Введите номер стационарного телефона (83435123456)");
input = Console.ReadLine();

while (PhoneNumberCheck(input) == 0)
{
    Console.WriteLine("Введите номер мобильного телефона (83435123456)");
    input = Console.ReadLine();
}
flatphone = PhoneNumberCheck(input);

Person prs = new(fio, street, housenumber, flatnumber, mobilephone, flatphone);

prs.SaveToFile();

Console.ReadKey();
