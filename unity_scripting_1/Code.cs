using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public int Hunger;
public class Code : MonoBehaviour
{
    Rigidbody2D rb;
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        // game logic here
    }
    

void Awake()
{
    Hunger = 100;
}

void FixedUpdate()
{
    // Physics related code here
}

}
