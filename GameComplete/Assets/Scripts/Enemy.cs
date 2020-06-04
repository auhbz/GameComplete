using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxSpeed, minSpeed;
    public int damage;
    
    float speed;

    Bean playerScript;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Bean>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        
    }

    void OnTriggerEnter2D(Collider2D hitObject) {
        if (hitObject.tag == "Player") {
            playerScript.TakeDamage(damage);
            Destroy(gameObject);
        }
        
        if (hitObject.tag == "Ground") {
            Destroy(gameObject);
        }        
    }
}
