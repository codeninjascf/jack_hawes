using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public GameObject mainMenu;

    public GameObject gameOverMenu;
    public TextMeshProUGUI gameOverScoreText;
    public TextMeshProUGUI gameOverHighScore;


    private bool _gameOver;
    private int _highScore;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.gameObject.SetActive(false);
        mainMenu.SetActive(true);
        gameOverMenu.SetActive(false);
        _gameOver = false;
        _highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = GameManager.Score.ToString();  
        if (!_gameOver && GameManager.GameOver)
        {
            _gameOver = true;

        }
    }
}
