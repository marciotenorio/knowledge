using System.Numerics;
using BenchmarkDotNet.Attributes;

namespace Benchmark;

public class Arrays
{
    [Benchmark]
    public void AcessarComArrayBidimensional()
    {   
        int[,] matriz = new int[1000, 1000];  
        int soma = 0;
        for (int i = 0; i < 1000; i++)
            for (int j = 0; j < 1000; j++)
                soma += matriz[i, j];
    }
    
    [Benchmark]
    public void AcessarComJagged()
    {
        int[][] jagged = new int[1000][]; 
        for (int i = 0; i < 1000; i++)
            jagged[i] = new int[1000];
    
        int soma = 0;
        for (int i = 0; i < 1000; i++)
            for (int j = 0; j < 1000; j++)
                soma += jagged[i][j];
    }
    
    [Benchmark]
    public void AcessarComSpanStackAlloc()
    {
        Span<int> buffer = stackalloc int[1000];
        for (int i = 0; i < buffer.Length; i++)
            buffer[i] = i;
    }

    [Benchmark]
    public void AcessarComArray()
    {
        int[] buffer = new int[1000];
        for (int i = 0; i < buffer.Length; i++)
            buffer[i] = i;
    }
    
    BigInteger Fib(int n, Span<BigInteger> memo)
    {
        if(n <= 1) return new BigInteger(n);
        if(memo[n] != 0) return memo[n];
    
        return memo[n] = Fib(n - 1, memo) + Fib(n - 2, memo);
    }
    
    BigInteger Fib2(int n, BigInteger[] memo)
    {
        if(n <= 1) return new BigInteger(n);
        if(memo[n] != 0) return memo[n];
    
        return memo[n] = Fib2(n - 1, memo) + Fib2(n - 2, memo);
    }
    
    [Benchmark]
    public void FibWithSpan()
    {
        var memo = new Span<BigInteger>(new BigInteger[1_000_000]);
        Fib(10_000, memo);
    }
    
    [Benchmark]
    public void FibWithArray()
    {
        var memo = new BigInteger[1_000_000];
        Fib2(10_000, memo);
    }
}