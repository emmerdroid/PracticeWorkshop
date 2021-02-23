using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Movement : MonoBehaviour
{

    public float speed = 5;
    private Rigidbody rb;
    private BoxCollider BC;
    [SerializeField] private LayerMask platformLayerMask;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        BC = transform.GetComponent<BoxCollider>();
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
    }

    private bool IsGrounded()
    {   
        RaycastHit2D ray = Physics2D.BoxCast(BC.bounds.center, BC.bounds.size, 0f, Vector2.down, .1f, platformLayerMask);
        return ray.collider != null;
    }
}
