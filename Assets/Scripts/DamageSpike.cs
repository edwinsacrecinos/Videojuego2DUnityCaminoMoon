using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSpike : MonoBehaviour
{
    
  
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.transform.CompareTag("Player")){
            Debug.Log("-15 de vida");
           // Destroy(collision.gameObject);
        }

    }


}
