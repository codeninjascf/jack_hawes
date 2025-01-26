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
    }
}
