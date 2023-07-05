using System;
public class _number
{
    public long number_in{get;set;}
    public int number_out{get;set;}
}
public class Program2
{
    public static object x = new object();
    public static void isprime(object x)
    {
        var inputs = x as _number;
        var input = inputs.number_in;
        if(input==1)
        {
            inputs.number_out = 0;
            return;
        }
        for(int i=2;i<(int)Math.Pow(input,0.5);i++)
        {
            if(input % i == 0)
            {
                inputs.number_out=0;
                return;
            }
        }
        inputs.number_out=1;
        return;
    }
    public static long primenuber_generator(int number_of_digits)
    {
        var d = new _number()
        {
            number_in = 0
        };
        for(int i=(int)(Math.Pow(10,number_of_digits-1));i<Math.Pow(10,number_of_digits);i++)
        {
            d.number_in = i;
            isprime(d);
            if(d.number_out==1)
                return i;
        }
        return 0;
    }

}