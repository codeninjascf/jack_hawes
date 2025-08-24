using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public float bulletSpeed = 20f;


    public GameObject crosshair;
    public GameObject bulletStart;
    public GameObject bulletPrefab;

    private Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        _camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
