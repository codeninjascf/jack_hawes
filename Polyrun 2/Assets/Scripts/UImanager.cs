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
        
    }
}
