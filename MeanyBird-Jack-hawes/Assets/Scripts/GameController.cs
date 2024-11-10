using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject GOC;
    public GameObject SC;
    public GameObject sp;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        SC.SetActive(true);
        GOC.SetActive(false);
        sp.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        GOC.SetActive(true);
        sp.SetActive(false);
        Time.timeScale = 0;
    }
}
