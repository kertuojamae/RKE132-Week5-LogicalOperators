//Math >= 90 OR Chemestry >= 90
//Math && Chemestry || Math && Biology || Chemestry && Biology

int math, biology, chemestry;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter yout Biology result;");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemestry result:");
chemestry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemestry >= 90) || (math >= 90 && biology >= 90 ) || (chemestry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You got accepted");
}
else
{
    Console.WriteLine("Your applications cannot be approved.");
}
