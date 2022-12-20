using ConsoleApp3.session1;
using TT2203E.session1;
public class Program
{
    static void Main(string[] args)
    {
        Human h = new Human();
        h.Run();
        h.Age= 1;
        h.Email = "ABC@GMAIL.COM";
        Student s  = new Student();
        //s.telephone[0] = "129038912";
        s[0] = "1838192839";
        s[1] = "1838192839";
        s[2] = "1838192839";
        List<string> ls  = new List<string>();
        ls.Add("hello");
        ls.Add("hello");
        ls.Add("hello");
        for(int i = 0;i<ls.Count;i++) {
            Console.WriteLine(ls[i]);
        }
        foreach(string l in ls)
        {
            Console.WriteLine(l);
        }

    }
}


