using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float jumpforce = 25f;

    private bool _isGrounded;
    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && _isGrounded)
        {
            _rigidbody.velocity = Vector2.zero;
            _rigidbody.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            if (PlayerCollisions.CollidedWithSide(gameObject, other.gameObject, PlayerCollisions.Side.Bottom))
            {
                _isGrounded = true;
            }
            else
            {
                GameManager.EndGame();
            }
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            GameManager.EndGame();
        }

    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {

            _isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {

            _isGrounded = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            GameManager.Score += 25;
            other.gameObject.SetActive(false);
        }
    }


}