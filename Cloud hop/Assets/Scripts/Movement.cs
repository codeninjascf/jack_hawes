using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 10f;
    public float jumpForce = 15f;

    private Rigidbody2D _rigidbody;
    private bool _canJump;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()

    {
        if (_rigidbody.velocity.y > -.01 && _rigidbody.velocity.y < .01)
        {
            _canJump = true;
        }
        else
        {
            _canJump = false;
        }
         if(_canJump && Input.GetButtonDown("Jump"))
        {
            _rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        float movement = moveSpeed * Input.GetAxis("Horizontal");
        transform.position += movement * Time.deltaTime * Vector3.right;
    }
}
