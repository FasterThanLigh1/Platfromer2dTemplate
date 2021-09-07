using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : Enemies//Inheritance
{
    //Polymorphism
    [SerializeField] LayerMask ground;
    [SerializeField] float jumpHeight = 10.0f;
    [SerializeField] float jumpLength = 10.0f;
    protected override void Move()
    {
        //Frog jump
        if(colli.IsTouchingLayers(ground))
        {
            rb.velocity = new Vector2(jumpLength * direction * Time.deltaTime, jumpHeight * Time.deltaTime);
        }
    }
}
