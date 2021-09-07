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
    Collider2D colli;
    float horizontal;
    float direction = 1;
    bool isJumping = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        colli = GetComponent<Collider2D>();
    }

    // Update is called once per frame

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump") && colli.IsTouchingLayers(ground))
        {
            isJumping = true;
        }
        if(horizontal > 0)
        {
            direction = 1;
        }
        if(horizontal < 0)
        {
            direction = -1;
        }
        transform.localScale = new Vector3(direction, 1, 1);
    }
    void FixedUpdate()
    {
        if(isJumping)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * Time.deltaTime);
            isJumping = false;
        }
        rb.velocity = new Vector2(speed * horizontal * Time.deltaTime, rb.velocity.y);
    }
    
}
