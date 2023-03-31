using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : testerScript
{
    public Pool[] pools;
    public GameObject poolObject;
    public override void TestFunction(bool status)
    {
        if (status) SpawnFromPool(pools[0]);

    }
    public void SpawnFromPool(Pool pool, Vector3 position = default, Quaternion rotation = default, Transform parent = default)
    {
        GameObject obj = Instantiate(pool.poolPrefab, position, rotation, parent);
        pool.pooledObjects.Add(obj);
    }
}
