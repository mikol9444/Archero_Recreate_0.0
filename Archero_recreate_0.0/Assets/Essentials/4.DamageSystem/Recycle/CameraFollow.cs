using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector2 xBounds = new Vector3(-10f, 10f);
    [SerializeField] private Vector2 zBounds = new Vector3(-10f, 10f);

    private Vector3 _offset;
    public Color gizmoColor = Color.red;

    private void Start()
    {
        // Calculate the initial offset between the camera and player
        _offset = transform.position - playerTransform.position;
    }

    private void LateUpdate()
    {
        // Calculate the desired position of the camera based on the player's position and offset
        Vector3 desiredPosition = playerTransform.position + _offset;

        // Clamp the desired position to the given bounds
        float clampedX = Mathf.Clamp(desiredPosition.x, xBounds.x, xBounds.y);
        float clampedZ = Mathf.Clamp(desiredPosition.z, zBounds.x, zBounds.y);
        desiredPosition = new Vector3(clampedX, desiredPosition.y, clampedZ);

        // Set the position of the camera to the desired position
        transform.position = desiredPosition;
    }

    private void OnDrawGizmosSelected()
    {
        // Draw the camera bounds as gizmos
        Gizmos.color = gizmoColor;

        // Gizmos.DrawLine(new Vector3(xBounds.x, 0, zBounds.x), new Vector3(xBounds.x, 0, zBounds.y));
        // Gizmos.DrawLine(new Vector3(xBounds.x, 0, zBounds.y), new Vector3(xBounds.y, 0, zBounds.y));
        // Gizmos.DrawLine(new Vector3(xBounds.y, 0, zBounds.y), new Vector3(xBounds.y, 0, zBounds.x));
        // Gizmos.DrawLine(new Vector3(xBounds.y, 0, zBounds.x), new Vector3(xBounds.x, 0, zBounds.x));
        Vector3 center = new Vector3((xBounds.x + xBounds.y) / 2f, 0.15f, (zBounds.x + zBounds.y) / 2f);
        Vector3 size = new Vector3(xBounds.y - xBounds.x, 0.15f, zBounds.y - zBounds.x);
        Gizmos.DrawCube(center, size);
    }
}
