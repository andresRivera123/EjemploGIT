using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    
    public float speed = 7;
    public Rigidbody2D rgb;

    private Vector2 startPosition;

    void Start()
    {
        transform.position = startPosition;
        Launch();
    }

    //Funcion para que la bola empieze la partida con la dirrección aleatoria.
    public void Launch()
    {
        //Si el valor sale 0 la bola hira hacia la izquierda
        //Si el valor sale 1 la bora hira hacia la derecha
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rgb.velocity = new Vector2(speed * x, speed * y);
    }

    public void Reset()
    {
        transform.position = startPosition;
        rgb.velocity = Vector2.zero;
        Launch();
    }
}
