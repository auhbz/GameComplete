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
        // if (input != 0) {
        //     anim.SetBool("isRunning", true);
        // } else {
        //     anim.SetBool("isRunning", false);
        // }
        // if (input > 0) {
        //     transform.eulerAngles = new Vector3(0, 0, 0);
        // } else if (input < 0) {
        //     transform.rotate(0,180,0);// = new Vector3(0, 90, 0);
        // }
        if (input > 0) {
            transform.eulerAngles = new Vector3(0, 0, 0);
            anim.SetBool("isRunning", true);
        } else if (input < 0) {
            transform.eulerAngles = new Vector3(0, 180, 0);
            anim.SetBool("isRunning", true);
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
