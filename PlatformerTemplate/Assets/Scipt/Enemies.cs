using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            PlayerController p = other.gameObject.GetComponent<PlayerController>();
            p.hpProperty -= 1;
            print("Collide and hp is " + p.hpProperty);
        }
    }
}
