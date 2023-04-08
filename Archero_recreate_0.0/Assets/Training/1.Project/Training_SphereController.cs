using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//Um das alte InputSystem zu nutzen soll die auskommentiete Klasse unten verwendet werden und die aktualle (ganz unten) soll gelöscht oder auskommentiert werden.

// public class Training_SphereController : MonoBehaviour
// {
//     public int itemCount = 0;
//     // Start is called before the first frame update
//     void Start()
//     {
//         keyboard = Keyboard.current;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetKey(KeyCode.W)) transform.position += Vector3.forward * 3f * Time.deltaTime;
//         if (Input.GetKey(KeyCode.A)) transform.position += Vector3.left * 3f * Time.deltaTime;
//         if (Input.GetKey(KeyCode.S)) transform.position += Vector3.back * 3f * Time.deltaTime;
//         if (Input.GetKey(KeyCode.D)) transform.position += Vector3.right * 3f * Time.deltaTime;
//     }

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("Item"))
//         {
//             Destroy(other.gameObject);
//             Debug.Log($"items collected: {itemCount++}");
//         }
//     }
// }

public class Training_SphereController : MonoBehaviour
{
    Keyboard keyboard;
    public int itemCount = 0;
    void Start()
    {
        keyboard = Keyboard.current;
    }

    void Update()
    {

        if (keyboard.wKey.isPressed)
        {
            transform.position += Vector3.forward * 3f * Time.deltaTime;
        }
        if (keyboard.aKey.isPressed)
        {
            transform.position += Vector3.left * 3f * Time.deltaTime;
        }
        if (keyboard.sKey.isPressed)
        {
            transform.position += Vector3.back * 3f * Time.deltaTime;
        }
        if (keyboard.dKey.isPressed)
        {
            transform.position += Vector3.right * 3f * Time.deltaTime;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Destroy(other.gameObject);
            Debug.Log($"items collected: {++itemCount}");
        }
    }
}


