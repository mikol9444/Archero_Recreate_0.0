using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public float minZ = -10f;
    public float maxZ = 10f;
    public float minX = -10f;
    public float maxX = 10f;

    private void LateUpdate()
    {
        // Get the current position of the camera
        Vector3 pos = transform.position;

        // Set the Z position of the camera to the player's Z position
        pos.z = playerTransform.position.z;
        pos.x = playerTransform.position.x;

        // Clamp the Z position to the given bounds
        pos.z = Mathf.Clamp(pos.z, minZ, maxZ);
        pos.x = Mathf.Clamp(pos.x, minX, maxX);

        // Set the new camera position
        transform.position = pos;
    }

    private void OnDrawGizmosSelected()
    {
        // Draw the camera bounds as gizmos
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector3(0f, .5f, minZ), new Vector3(0f, .5f, maxZ));
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(new Vector3(minX, .5f, 0f), new Vector3(maxX, .5f, 0f));
    }
}
