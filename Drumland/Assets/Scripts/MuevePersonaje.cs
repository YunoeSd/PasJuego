using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Gala Flores García 
 * Indica el movimiento del personaje principal
 */
public class MuevePersonaje : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;

    private SpriteRenderer sprRenderer;

    //velocidad
    public float velocidadX = 10;
    public float velocidadY = 10;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movHorizontal * velocidadX, rb.velocity.y);

        float movVertical = Input.GetAxis("Vertical");
        if (movVertical > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, movVertical * velocidadY);
        }
        //Animaci�n
        float velocidad = Mathf.Abs(rb.velocity.x);
        animator.SetFloat("velocidad", velocidad);
        //Direcci�n
        sprRenderer.flipX = rb.velocity.x < 0;

        animator.SetBool("saltando", !PruebaPiso.saltando);
    }
}