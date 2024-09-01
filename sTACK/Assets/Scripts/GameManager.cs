using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Spawner spawner;
    public CameraFollow view;
    public UIManager uiManager;

    private bool _gameOver;
    // Start is called before the first frame update
    void Start()
    {
        spawner.Spawn();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1") && !_gameOver)
        {
            BlockMovement.CurrentBlock.Stop();
            if (BlockMovement.GameOver)
            {
                _gameOver = true;

            }
            spawner.Spawn();
            view.Height = spawner.GetNewHeight();
            uiManager.Score++;

                    
        }
    }
}
