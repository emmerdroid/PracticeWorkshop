using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Movement : MonoBehaviour
{

    public float speed = 5;
    private Rigidbody2D rb;
    private BoxCollider2D BC;
    [SerializeField] private LayerMask platformLayerMask;
    [SerializeField] private GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        BC = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed *Time.deltaTime, 0f, 0f);

        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            float jumpVel = 5f;
            rb.velocity = Vector2.up * jumpVel;

        }
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            shoot();
        }
    }

    private bool IsGrounded()
    {   
        RaycastHit2D ray = Physics2D.BoxCast(BC.bounds.center, BC.bounds.size, 0f, Vector2.down, .1f, platformLayerMask);
        return ray.collider != null;
    }

    private void shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
