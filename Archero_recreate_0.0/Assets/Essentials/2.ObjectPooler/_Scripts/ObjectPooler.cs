using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public Pool[] pools;
    // Dictionary to store the poolName and corresponding pool index
    private Dictionary<string, int> poolDictionary = new Dictionary<string, int>();
    public static ObjectPooler Instance;
    private void Awake()
    {
        Initialize();
        Instance = this;

    }
    public void TestFunction(bool status)
    {
    }
    //--------------------DEPENDENCY--------------------------------
    private void OnEnable()
    {
        FindObjectOfType<InputManager>()._inputReader.TestEvent += TestFunction;

    }
    private void OnApplicationQuit()
    {

        FindObjectOfType<InputManager>()._inputReader.TestEvent -= TestFunction;
    }
    //--------------------DEPENDENCY--------------------------------
    private void Initialize()
    {
        // PREINITIALIZE Prefab amount from each pool and Add the pool name and index to the dictionary
        int index = 0;
        foreach (Pool pool in pools)
        {
            for (int i = 0; i < pool.preinstantiateAmount; i++)
            {
                GameObject obj = InitObject(pool, false);

            }
            // 
            poolDictionary.Add(pool.poolName, index++);
        }
    }

    private Pool SelectPool(string poolName)
    {
        int index = poolDictionary.GetValueOrDefault(poolName);
        //Debug.Log($"Selected pool index: {index} input name {poolName} pool name {pools[index].poolName} ");
        return pools[index];
    }
    private GameObject InitObject(Pool pool, bool state)
    {
        if (pool.CanPull)
        {
            GameObject obj = Instantiate(pool.prefab);
            pool.AddObject(obj);
            obj.SetActive(state);
            return obj;
        }
        return null;
    }

    public GameObject PoolObject(string poolName)
    {
        Pool pool = SelectPool(poolName);
        GameObject obj = pool.FirstInactive(pool);
        if (obj == null) obj = InitObject(pool, true);
        return obj;
    }


}