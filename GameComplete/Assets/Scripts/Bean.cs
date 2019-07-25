using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bean : MonoBehaviour
{
    public float speed;
    Rigidbody2D rigBod;

    // Start is called before the first frame update
    void Start()
    {
        rigBod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Horizontal");
        // float input = Input.GetAxis("Horizontal");
        
        rigBod.velocity = new Vector2(input*speed, rigBod.velocity.y);
    }
}
