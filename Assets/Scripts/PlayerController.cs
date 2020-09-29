using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject BarraDeSalud;


    void Start (){
        BarraDeSalud = GameObject.Find("BarraSalud");
    }

    void OnTriggerEnter2D(Collider2D collition)
    {
        
        if (collition.gameObject.tag == "Enemy"){
            
           BarraDeSalud.SendMessage("BajarSalud",20);
        }
    }


   

}
