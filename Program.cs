using System.Diagnostics;



long calculate_prime(int prime_number_digits,int numberofthreads)
{
    Thread[] threads = new Thread[numberofthreads];
    for(int i = 0;i<threads.Length;i++)
        threads[i] = new Thread(Program2.isprime);



    Stopwatch sw = Stopwatch.StartNew();
    _number input = new _number()
    {
        number_in = Program2.primenuber_generator(prime_number_digits)
    };

    for(int i = 0;i<threads.Length;i++)
        threads[i].Start(input);


    for(int i = 0;i<threads.Length;i++)
        threads[i].Join();

    for(int i = 0;i<threads.Length;i++)
        System.Console.WriteLine(input.number_out);

    System.Console.WriteLine($"time: {sw.ElapsedMilliseconds}");

    return sw.ElapsedMilliseconds;
}

var x = Enumerable
.Range(1,30)
.Select(i=>(time:calculate_prime(10,i), numberofthreads:i))
.ToList();

var y = x.MinBy(i=>i.time);

System.Console.WriteLine($"the number of threads that works out the best for this prime number is {y.numberofthreads} with the time : {y.time} milliseconds.");