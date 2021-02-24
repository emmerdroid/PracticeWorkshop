using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Bullet : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody2D bullet;
    public int damage = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        bullet.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        Destroy(gameObject);
    }
}
