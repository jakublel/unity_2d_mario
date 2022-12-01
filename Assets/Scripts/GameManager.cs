using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text scoreText;

    private float score;

    public float worldScrollingSpeed = 0.2f;

    public bool inGame;
    public GameObject gameOverText;
    public GameObject resetButton;

    // Start is called before the first frame update
    void Start()
    {
        if (instance==null)
        {
            instance = this;
        }

        InitializeGame();
    }

    void InitializeGame()
    {
        inGame = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!GameManager.instance.inGame) return;
        score += worldScrollingSpeed;
        UpdateOnScreenScore();
    }

    void UpdateOnScreenScore()
    {
        scoreText.text = score.ToString("0");
    }

    public void GameOver()
    {
        inGame = false;
        gameOverText.SetActive(true);
        resetButton.SetActive(true);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }

}
