using ConsoleApp3.session1;
using TT2203E.session1;
using TT2203E.session3;
using TT2203E.session3.assignment;

public class Program
{
    static void Main(string[] args)
    {
        PhoneBook pb = new PhoneBook();
        pb.InsertPhone("Nam", "289348239");
        pb.InsertPhone("Nam","111111111111");
        pb.InsertPhone("Nam4", "333444444");
        pb.InsertPhone("Nam5", "333333333");
        pb.InsertPhone("Nam6", "222222222");
        

        foreach(PhoneNumber p in pb.PhoneList)
        {
            Console.WriteLine(p.ToString());
        }
        pb.Sort();
    }
    static void Main3(string[] args)
    {
        try
        {
            int x = 10;
            int y = 0;
            throw new Exception("Y bang 0 mat roi");
            float z = x / y;

        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {

        }
    }
    static void Main2(string[] args)
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


