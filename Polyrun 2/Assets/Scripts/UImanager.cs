using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI scoretext;

    public GameObject Mainmenu; 

    public GameObject gameOverMenu;
    public TextMeshProUGUI gameOverScoreText;
    public TextMeshProUGUI gameOverHighScoreText;
    private bool _GameOver;
    private int _highScore;


    // Start is called before the first frame update
    void Start()
    {
        scoretext.gameObject.SetActive(false);
        Mainmenu.SetActive(true);
        gameOverMenu.SetActive(false);
        _GameOver = false;
        _highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = GameManager.Score.ToString();
        if (!_GameOver && GameManager.GameOver)
        {
            _GameOver = true;
            scoretext.gameObject.SetActive(false);
            gameOverMenu.SetActive(true);
            if (GameManager.Score > _highScore)
            {
                _highScore = GameManager.Score;
                PlayerPrefs.SetInt("HighScore", _highScore);
            }
            gameOverScoreText.text = "Score:" + GameManager.Score;
            gameOverHighScoreText.text = "High Score" + _highScore;
            
        }
    }

    public void StartGame()
    {
        Mainmenu.SetActive(false);
        scoretext.gameObject.SetActive(true);
        GameManager.StartGame();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
