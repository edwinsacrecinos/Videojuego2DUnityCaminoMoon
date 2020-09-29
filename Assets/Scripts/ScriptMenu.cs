using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMenu : MonoBehaviour
{

public void PlayGame()
{
    //Forma principal
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //Forma secundaria
    /* SceneManager.LoadScene("Level_1");   */
}

public void QuitGame ()
{
    Application.Quit();
}

   
}
