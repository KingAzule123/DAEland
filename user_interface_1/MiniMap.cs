using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public Camera miniMapCamera;
    public Transform player;

    void LateUpdate()
    {
        Vector3 newCameraPosition = player.position;
        newCameraPosition.y = miniMapCamera.transform.position.y;
        miniMapCamera.transform.position = newCameraPosition;

        miniMapCamera.transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }
}
