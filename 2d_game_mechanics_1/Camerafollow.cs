using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target (character) to follow
    public Vector3 offset = new Vector3(0f, 5f, -10f); // Camera offset
    public float smoothSpeed = 5f; // Smoothness factor

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("CameraFollow: No target assigned!");
            return;
        }

        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.LookAt(target); // Makes the camera look at the character
    }
}
