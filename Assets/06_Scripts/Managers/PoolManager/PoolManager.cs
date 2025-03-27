using System.Collections.Generic;
using UnityEngine;

public class PoolManager : Singleton<PoolManager>
{
    private readonly Dictionary<string, Pool> pools = new();

    protected override void Initialize()
    {
        SetDontDestroyOnLoad();
    }

    public GameObject Get(string key)
    {
        if (pools.TryGetValue(key, out var pool) == false)
        {
            return null;
        }

        return pool.Get();
    }

    public void Release(Poolable poolable)
    {
        string key = poolable.name;
        if (pools.TryGetValue(key, out var pool) == false)
        {
            pool = new(key, transform);
            pools.Add(key, pool);
        }

        pool.Release(poolable);
    }
}