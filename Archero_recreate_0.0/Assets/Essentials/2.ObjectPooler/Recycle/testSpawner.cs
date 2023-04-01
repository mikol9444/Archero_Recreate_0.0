using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testSpawner : MonoBehaviour
{

    ObjectPooler pooler;

    private void Start()
    {
        pooler = ObjectPooler.Instance;
    }
    public void SpawnCube()
    {
        GameObject obj = pooler.PoolObject("default");
    }
}
