
string txt = "30123;51230;2342520;10454;1300;13450;55670";

string[] txtArray =  txt.Split(';');
int sum = 0;

foreach (string str in txtArray)
{
    sum += Int32.Parse(str);
}

Console.WriteLine($"The sum of the integers in txt is: {sum:N0}"); 