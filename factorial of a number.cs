using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int num, snum, ans;
        
        ans = 1;
        snum = 1;
        Console.WriteLine("لطفا یک عدد وارد کنید");
        num = (int) inputValue();
        while (snum <= num)
        {
            ans = ans * snum;
            snum = snum + 1;
        }
        Console.WriteLine("جواب شما");
        Console.WriteLine(ans);
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
