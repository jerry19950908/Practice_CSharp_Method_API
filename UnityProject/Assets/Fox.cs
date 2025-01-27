﻿using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移動速度"), Range(0f, 20f)]
    public float speed = 5f;
    [Header("推力"),]
    public int thrust;
   
   
    public SpriteRenderer sr;
    
    public Transform fox;

    public Rigidbody2D push;


    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal") * Time.deltaTime;

        fox.Translate(h*speed, 0, 0);
        push.AddForce(new Vector2(h*thrust, 0));
    }
   

    private void Update()
    {
        Move();

        if (Input.GetKey("a"))
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }

        
    }

    









}
