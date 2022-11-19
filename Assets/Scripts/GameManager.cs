using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text scoreText;

    private float score;

    public float worldScrollingSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        if (instance==null)
        {
            instance = this;
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        score += worldScrollingSpeed;
        UpdateOnScreenScore();
    }

    void UpdateOnScreenScore()
    {
        scoreText.text = score.ToString("0");
    }
}
