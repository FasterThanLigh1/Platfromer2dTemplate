using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField] int hp = 3;
    public int hpProperty
    {
        get{ return hp; }
        set{ hp = value; }
    }
    [SerializeField] float jumpForce = 10.0f;
    [SerializeField] float speed = 10.0f;
    [SerializeField] LayerMask ground;
    Collider2D collider;
    float horizontal;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump") && collider.IsTouchingLayers(ground))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * Time.deltaTime);
        }
        rb.velocity = new Vector2(speed * horizontal * Time.deltaTime, rb.velocity.y);
    }
    
    
}
