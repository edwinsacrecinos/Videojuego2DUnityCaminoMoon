using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesPausa : MonoBehaviour
{
    
    
    public Canvas canvas;


public void ReiniciarMiNivel(){
    canvas.enabled=false;
    SceneManager.LoadScene("Level_1");
    Time.timeScale =  1f;
    
}

public void SalirMenu(){
    canvas.enabled=false;
    SceneManager.LoadScene("MainMenu");
    Time.timeScale =  1f;
    
}

public void SalirJuego (){
Application.Quit();
}

}
