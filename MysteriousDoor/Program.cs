Console.WriteLine("Hello, World!");

string secretCode = "26";
string attempt = "";

while(attempt != secretCode)
{
    Console.WriteLine("Enter The Secret Code : ");
    attempt = Console.ReadLine();
    if(attempt!= secretCode)
    Console.WriteLine("kamu salah");
}
Console.WriteLine("sangar cyak arek tepak");