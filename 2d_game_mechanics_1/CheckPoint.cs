using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public static Vector3 CurrentRespawnPoint;

    void OnTriggerExit2D(Collider2D other) {
        if(other.Comparetag("player"))
        {
            CurrentRespawnPoint = transform.position;
        }

    }
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
