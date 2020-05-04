using System;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;
using TrimDB.Core.SkipList;

namespace TrimDB.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var sl = new SkipListInsert();
            sl.TableHeight = 20;
            sl.GlobalSetup();
            sl.IterationSetup();
            sl.NativeAllocator().GetAwaiter().GetResult();

            var summary = BenchmarkRunner.Run<SkipListInsert>();


        }
    }
}
