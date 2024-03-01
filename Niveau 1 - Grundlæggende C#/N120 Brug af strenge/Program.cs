
// To make console output danish letters
Console.OutputEncoding = System.Text.Encoding.UTF8;

string fornavn = "Jesper";
string efternavn = "Højlund";
string samletNavn = fornavn + " " + efternavn;
Console.WriteLine(samletNavn);

string navnStort = samletNavn.ToUpper();
Console.WriteLine(navnStort);

string navnLille = samletNavn.ToLower();
Console.WriteLine(navnLille);

string navnSubstring1 = samletNavn.Substring(efternavn.Length, 3);
Console.WriteLine(navnSubstring1);

string navnSubstring2 = char.ToUpper(samletNavn[^4]) + samletNavn.Substring(samletNavn.Length - 3);
Console.WriteLine(navnSubstring2);
