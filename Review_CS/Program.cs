using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // [1] 자료형은 결국 "몇 바이트를 쓰느냐"의 문제
        Console.WriteLine("=== 크기(바이트) ===");
        Console.WriteLine($"bool   : {sizeof(bool)}");
        Console.WriteLine($"char   : {sizeof(char)}");
        Console.WriteLine($"int    : {sizeof(int)}");
        Console.WriteLine($"long   : {sizeof(long)}");
        Console.WriteLine($"double : {sizeof(double)}");

        // [2] 숫자를 2진수로 직접 보기
        Console.WriteLine("\n=== 2진수 ===");
        foreach (int n in new[] { 1, 2, 5, 8, 255 })
            Console.WriteLine($"{n,3} -> {Convert.ToString(n, 2).PadLeft(8, '0')}");

        // [3] 오버플로 - 스위치가 한 바퀴 돈다
        Console.WriteLine("\n=== 오버플로 ===");
        int max = int.MaxValue;
        Console.WriteLine($"int.MaxValue     : {max}");
        Console.WriteLine($"int.MaxValue + 1 : {max + 1}");   // 에러 없이 음수!

        // [4] 실수의 오차
        Console.WriteLine("\n=== 실수 ===");
        Console.WriteLine($"0.1 + 0.2        = {0.1 + 0.2}");
        Console.WriteLine($"0.1 + 0.2 == 0.3 ? {0.1 + 0.2 == 0.3}");
        Console.WriteLine($"decimal 은?        {0.1m + 0.2m == 0.3m}");

        // [5] 글자는 숫자다
        Console.WriteLine("\n=== 문자 ===");
        Console.WriteLine($"'A' -> {(int)'A'}");
        Console.WriteLine($"'가' -> {(int)'가'}");
        Console.WriteLine($"\"안녕\".Length = {"안녕".Length}");
        Console.WriteLine($"\"👍\".Length  = {"👍".Length}");   // 1이 아님!
    }
}
