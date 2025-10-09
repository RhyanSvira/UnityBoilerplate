using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenuController : MonoBehaviour
{

    //load game scene
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}


