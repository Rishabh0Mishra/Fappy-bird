using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int playerscore;
    public Text scoreText;
    public GameObject gameoverScreen;

    [ContextMenu("increase score")]
    public void addScore(int scoretoadd)
    {
        playerscore = playerscore + scoretoadd;
        scoreText.text = playerscore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        gameoverScreen.SetActive(true);
    }
}
