using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarraSaludPlayer : MonoBehaviour
{
    
public Image salud;
public float hp, maxHP = 100f;


void Start(){
    hp = maxHP;
}

public void BajarSalud(float bajada){
    
    hp = Mathf.Clamp(hp -bajada,0f, maxHP);
    salud.transform.localScale = new Vector2(hp/maxHP,1);
    if (hp==0){
        Destroy(GameObject.FindWithTag("Player"));
        ReiniciarJuego();
    }
}

public void ReiniciarJuego (){
    SceneManager.LoadScene("Level_1");
}


}
