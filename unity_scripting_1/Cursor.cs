using UnityEngine;

public class LookAtMouse : MonoBehaviour
{

    public float rotationOffset = 90f;
    
    void Update()
    {
        // Get mouse position in world space
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Find direction from player to mouse
        Vector3 direction = mousePos - transform.position;

        // Zero out Z axis for 2D
        direction.z = 0f;

        // Calculate rotation angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply rotation only on Z axis
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
