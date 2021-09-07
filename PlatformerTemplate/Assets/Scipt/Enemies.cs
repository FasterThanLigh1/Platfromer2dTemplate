using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed;
    protected Rigidbody2D rb;
    protected Collider2D colli;
    protected int direction = 1;
    [SerializeField] float timer = 3f;
    [SerializeField] float timeFlow;
    void Start()
    {
        colli = GetComponent<Collider2D>();
        timeFlow = timer;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
        if(timeFlow < 1)
        {
            direction *= -1;
            transform.localScale = new Vector3(-direction, 1, 1);
            timeFlow = timer;
        }else
        {
            timeFlow -= Time.deltaTime;
        }   
    }
    void FixedUpdate()
    {
        Move();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            PlayerController p = other.gameObject.GetComponent<PlayerController>();
            p.hpProperty -= 1;
            print("Collide and hp is " + p.hpProperty);
        }
    }
    protected virtual void Move()
    {
        rb.velocity = new Vector2(speed * direction * Time.deltaTime, rb.velocity.y);
    }
}
