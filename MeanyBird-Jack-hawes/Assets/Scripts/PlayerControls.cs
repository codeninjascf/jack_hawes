using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //Game manager object
    [Header("Game Controller Object for controllingthe game")]
    public GameController Controller;
    [Header("Default Velocity")]
    public float velocity = 1;
    //Physics for the bird
    private Rigidbody2D rb;
    //height of the bird object on the y axis
    private float objectHeight;


    // Start is called before the first frame update
    void Start()
    {
        GameController = GetComponent<GameController>();
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        objectHeight
    }

    // Update is called once per frame
    void Update()
    {

    }
}
