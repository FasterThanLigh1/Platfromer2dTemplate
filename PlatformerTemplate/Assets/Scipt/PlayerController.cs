using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    float horizontal;
    [SerializeField] float speed = 10.0f; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        //rb.AddForce(Vector2.right * horizontal * speed);
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        rb.velocity = Vector2.right * horizontal * speed * Time.fixedDeltaTime;
    }
}
