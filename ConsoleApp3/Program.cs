using ConsoleApp3.session1;
using TT2203E.session1;
using TT2203E.session3;
using TT2203E.session3.assignment;
using TT2203E.session4;
public class Program
{   
    static void Main(string[] args)
    {
        StringToVoid stv = new StringToVoid(showMessage);
        StringToVoid stv2 = new StringToVoid(DemoDelegate.SayHello);//static
        StringToVoid stv3 = new StringToVoid(new DemoDelegate().ShowInfo);//method
        stv += DemoDelegate.SayHello;
        stv += new DemoDelegate().ShowInfo;
        stv += stv3;
        stv("xin chao cac ban");
    } 
    static void showMessage(string msg)
    {
        Console.WriteLine(msg);

    }
    static string GetMessage(string s)
    {
        return s;
    }
        static void Main4(string[] args)
    {
        PhoneBook pb = new PhoneBook();
        pb.InsertPhone("Nam", "289348239");
        pb.InsertPhone("Nam","111111111111");
        pb.InsertPhone("Nam4", "333444444");
        pb.InsertPhone("Nam5", "333333333");
        pb.InsertPhone("Nam6", "222222222");

        pb.Sort();
        foreach (PhoneNumber p in pb.PhoneList)
        {
            Console.WriteLine(p.ToString());
        }
        
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


