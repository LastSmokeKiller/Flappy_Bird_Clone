using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Score Keeper")]
    public int playerScore;
    public Text scoreText;
    public GameObject scoreCounter;

    [Header("Game Over")]
    public GameObject gameOverScreen;
    public bool gameIsOver = true;

    [Header("Sounds")]
    public AudioSource scoreSound;
    public AudioSource gameoverSound;

    [Header("Start Game")]
    public GameObject startGameScreen;
    public bool gameIsStarted = false;

    

    [ContextMenu("Increase Score")]
    public void addScore(int i)
    {
        playerScore += i;
        scoreText.text = playerScore.ToString();
        scoreSound.Play();
    }

   public void gameOver()
    {
        if (!gameIsOver)
        {
            gameOverScreen.SetActive(true);
            gameIsOver = true;
            gameoverSound.Play();
        }
    }

    /*(public void startGame()
    {
        gameIsOver = false;
        gameIsStarted = true;
        SceneManager.LoadScene("GameScene");

    }*/

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
