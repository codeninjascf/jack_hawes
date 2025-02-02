using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpForce = 15f;
    private Rigidbody2D _rigedbody;
    void Start()
    {
        _rigedbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movement = moveSpeed * Input.GetAxis("Horisontal");
        Player.Turn(_rigedbody,movement);
        _rigedbody.position += movement * Time.deltaTime * Vector2.right;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_rigedbody.velocity.y <= 0)
            _rigedbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

}
 