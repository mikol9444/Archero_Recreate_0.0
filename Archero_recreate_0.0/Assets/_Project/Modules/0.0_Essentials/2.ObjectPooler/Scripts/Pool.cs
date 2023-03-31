using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Pool
{
    public GameObject poolPrefab;
    public int preinstantiateAmount = 10;
    public bool expandable = true;
    public List<GameObject> pooledObjects;

}


