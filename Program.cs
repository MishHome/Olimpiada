using System.Text;
using System.Xml.Linq;

class Program
{
    static string z = "кукареку";
    static string y = "кареку";
    //static string z = "";

    public static void Main()
    {
        //z = x +'|'+ y;
        int k=0;
        int a=0;
        int cntwords = 1;
        StringBuilder sb= new StringBuilder();
        sb.Append(z);
        string s;
        
       
        while (true)
        {

            //ln = sb.Length;
            s = sb.ToString();
            k = MyCount(s, 'к');
            a = MyCount(s, 'а');
            // Console.WriteLine($"Word: {z}    Всего слов:{cntwords}   Букв к: {k}, а: {a}");
           
            if (k >= a + 160000)          break;
            //if (cntwords >=4)    break;
            sb.Append('|').Append(y);
           // z += '|' + y;
            cntwords++;
            //s = sb.Remove(ln, 6).ToString();
           


        }
        int cntR = MyCount(s, 'р');
        Console.WriteLine($"Word:, р={cntR}     Всего слов:{cntwords}   Букв к: {k}, а: {a}");
        //Console.WriteLine($"р={cntR}     Всего слов:{cntwords}   Букв к: {k}, а: {a}");
        // if (k >= a + 160)
        // Console.WriteLine(z);

    }

    static int MyCount(string mystring, char mychar)
    {
        int x = 0;
        foreach (char c in mystring)
        {
            if (c.Equals(mychar))
                x++;
            else
                continue;
        }
        return x;
    }

}
