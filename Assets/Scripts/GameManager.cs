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

    private int coins;

    public Text coinScoreText;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        InitializeGame();
    }

    public void CoinCollected(int value = 1)
    {
        coins += value;

        PlayerPrefs.SetInt("Coins",coins);
        UpdateOnScreenScore();
    }

    void InitializeGame()
    {
        inGame = true;

        if (PlayerPrefs.HasKey("Coins"))
        {
            coins = PlayerPrefs.GetInt("Coins");
        }
        else
        {
            coins = 0;
            PlayerPrefs.SetInt("Coins", 0);
        }
        UpdateOnScreenScore();
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
        coinScoreText.text = coins.ToString();
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
