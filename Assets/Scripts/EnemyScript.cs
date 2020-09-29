using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    
    
    void OnTriggerEnter2D(Collider2D collition)
    {
        if (collition.gameObject.tag == "Player"){
            
            if(transform.position.y < collition.transform.position.y){
                Destroy(gameObject);
            }

        }
        
    }

}
