using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections;
using System.Collections.Generic;

public class CollectionBenchmark
{
    private List<int> list;
    private HashSet<int> hashSet;
    private ArrayList arrayList;
    private Dictionary<int, int> dictionary;

    [Params(1, 2, 3)]
    public int N;

    [GlobalSetup]
    public void Setup()
    {
        list = new List<int>();
        hashSet = new HashSet<int>();
        arrayList = new ArrayList();
        dictionary = new Dictionary<int, int>();

        for (int i = 0; i < N; i++)
        {
            list.Add(i);
            hashSet.Add(i);
            arrayList.Add(i);
            dictionary.Add(i, i);
        }
    }

    [Benchmark]
    public void ListContains()
    {
        for (int i = 0; i < N; i++)
        {
            bool contains = list.Contains(i);
        }
    }

    [Benchmark]
    public void HashSetContains()
    {
        for (int i = 0; i < N; i++)
        {
            bool contains = hashSet.Contains(i);
        }
    }

    [Benchmark]
    public void ArrayListContains()
    {
        for (int i = 0; i < N; i++)
        {
            bool contains = arrayList.Contains(i);
        }
    }

    [Benchmark]
    public void DictionaryContainsKey()
    {
        for (int i = 0; i < N; i++)
        {
            bool contains = dictionary.ContainsKey(i);
        }
    }

    // Add more benchmark methods for other operations as needed
}

class Program
{
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<CollectionBenchmark>();
    }
}
