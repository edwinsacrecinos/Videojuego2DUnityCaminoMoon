using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
   
    //Velocidad de movimiento y salto del player
    public float velocidadCorrer=3f;
    public float VelocidadSalto= 7f;
    // Obtener spriteRender de Player
    public SpriteRenderer spriteRenderPlayer;
    // Acceder a animación
    public Animator AnimacionJugador;
     //Cuerpo jugador
    Rigidbody2D rb2D;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
       if (Input.GetKey("d"))
       {
           rb2D.velocity = new Vector2(velocidadCorrer,rb2D.velocity.y);
           spriteRenderPlayer.flipX = false;
           AnimacionJugador.SetBool("RunActivation",true);
       } 
       else if (Input.GetKey("a"))
       {
           rb2D.velocity = new Vector2(-velocidadCorrer,rb2D.velocity.y);
           spriteRenderPlayer.flipX= true;
           AnimacionJugador.SetBool("RunActivation",true);
       } 
       else 
       {
           rb2D.velocity = new Vector2(0f,rb2D.velocity.y);
           AnimacionJugador.SetBool("RunActivation",false);
       }
       if(Input.GetKey("space") && DetectarSuelo.TocarSuelo)
       {
           rb2D.velocity= new Vector2(rb2D.velocity.x, VelocidadSalto);
           AnimacionJugador.SetBool("JumpActivation",true);
           AnimacionJugador.SetBool("RunActivation",false);
       }
       if(DetectarSuelo.TocarSuelo==false){
           AnimacionJugador.SetBool("JumpActivation",true);
           AnimacionJugador.SetBool("RunActivation",false);
       }
        if(DetectarSuelo.TocarSuelo==true){
           AnimacionJugador.SetBool("JumpActivation",false);
       }
    }
}
