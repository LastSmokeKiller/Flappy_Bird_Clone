using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public void startGame()
    {

        SceneManager.LoadScene("GameScene");

    }

    public void exitGame()
    {
        Application.Quit();
    }
}
