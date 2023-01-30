using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public bool player1;
    public float speed = 3;
    public Rigidbody2D rgb;
    
    private float move;
    private Vector2 starsPosition;

    void Start()
    {
        starsPosition = transform.position;
    }

    
    void Update()
    {
        if (player1)
        {
            move = Input.GetAxisRaw("Vertical2");
        }
        else
        {
            move = Input.GetAxisRaw("Vertical1");
        }

        rgb.velocity = new Vector2(rgb.velocity.x, move * speed);
       
    }

    public void Reset()
    {
        rgb.velocity = Vector2.zero;
        transform.position = starsPosition;
    }
}
