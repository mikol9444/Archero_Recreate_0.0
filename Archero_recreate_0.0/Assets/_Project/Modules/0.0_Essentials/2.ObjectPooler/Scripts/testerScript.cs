using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script should be used to Quick Test implemented functions via Controll: Keycode.T or already implemented TestButton
//Inherit from this class and use override TestFunction -> additionally check if bool status is true or false to be called only once
public abstract class testerScript : MonoBehaviour
{
    private void Awake()
    {
        FindObjectOfType<InputManager>()._inputReader.TestEvent += TestFunction;
    }
    private void OnApplicationQuit()
    {
        FindObjectOfType<InputManager>()._inputReader.TestEvent -= TestFunction;
    }
    public virtual void TestFunction(bool status) { }
}
