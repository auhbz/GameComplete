using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bean : MonoBehaviour
{
    public float speed;
    private float input;
    
    Rigidbody2D rigBod;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rigBod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update() {

        if (input != 0) {
            anim.SetBool("isRunning", true);
             Vector3 scale = transform.localScale;
            if (input > 0) {
                scale.x = 1;
                transform.localScale = scale;
            } else if (input < 0) {
                scale.x = -1;
                transform.localScale = scale;
            }
        } else {
            anim.SetBool("isRunning", false);
        }
        
    }

    //Physics related update
    void FixedUpdate()
    {
        input = Input.GetAxisRaw("Horizontal");
        
        rigBod.velocity = new Vector2(input*speed, rigBod.velocity.y);
    }
}
