using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamare : MonoBehaviour
{
    
public GameObject follow;
public Vector2 minCamara, maxCamara;


void FixedUpdate()
{
    float posX = follow.transform.position.x;
    float posY = follow.transform.position.y;


    transform.position = new Vector3 (
        Mathf.Clamp (posX, minCamara.x, maxCamara.x),
        Mathf.Clamp (posY, minCamara.y, maxCamara.y),
        transform.position.z);
    

}



}
