using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movespeed;
    public float jumpforce;


    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private int Direction
    {
        get
        {
           if(GameManager.GameOver)
            {
                return 0;
            }
           if (GameManager.Player.transform.position.x < transform.position.x)
            {
                return -1;
            }
           if (GameManager.Player.transform.position.x > transform.position.x)
            {
                return 1;
            }
            return 0;
        }
        set 
        { 
        
        
        }

    }
}
