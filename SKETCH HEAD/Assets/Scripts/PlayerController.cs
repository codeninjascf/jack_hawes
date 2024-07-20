using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpForce = 15f;

    private Rigidbody2D rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>
    }


    void Update()
    {
        
    }
}
