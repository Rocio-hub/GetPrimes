using System.Collections.Concurrent;
using System.Diagnostics;

namespace CompulsoryAssignment
{
    public class PrimeGenerator
    {
        //1) First implement the function using a sequential approach, and check for correctness

        public List<long> GetPrimesSequential(long first, long last)
        {
            List<long> primeNumbers = new List<long>();

            for(long i = first; i<=last; i++)
                if(isPrimeNumber(i)) primeNumbers.Add(i);
            
            return primeNumbers;
        }

        //2) Then implement the function using parallel programming, and check for correctness (take care of race conditions
        //when writing in parallel to the list).

        public List<long> GetPrimesParallel(long first, long last)
        {
            List<long> primeNumbers = new List<long>();
            Object lockObject = new();

            Parallel.ForEach(Partitioner.Create(first, last), range =>
            {
                List<long> localList = new List<long>();
                for (long i = range.Item1; i < range.Item2; i++)
                {
                    if(isPrimeNumber(i)) localList.Add(i);
                }
                lock (lockObject) 
                {
                    primeNumbers.AddRange(localList);
                }

            });

            primeNumbers.Sort();
            return primeNumbers;
        }

        public bool isPrimeNumber(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public void performanceMeasurer(Action action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action.Invoke();
            stopwatch.Stop();
            Console.Write(stopwatch.Elapsed.TotalMilliseconds+"\n");
        }

        public Task<List<long>> GetPrimesAsync(long first, long last)
        {
            return Task.Factory.StartNew(() =>
            {
                return GetPrimesParallel(first, last);
            });
        }
    }
}
