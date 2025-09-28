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
        _rigidbody.velocity = Direction * movespeed * Vector2.right;
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))

        {
            _rigidbody.velocity = Direction * movespeed * Vector2.right;
            _rigidbody.AddForce(jumpforce * Vector2.up, ForceMode2D.Impulse);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            _rigidbody.velocity = Direction * movespeed * Vector2.left;
            _rigidbody.AddForce(jumpforce * Vector2.up, ForceMode2D.Impulse);
        }
    }
}
