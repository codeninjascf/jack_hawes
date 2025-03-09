using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spikes Object for controlling the game")]
    public GameObject spikes;
    [Header("Default Height")]
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObject", 1f, 4f); //creates spikes
        transform.position = new Vector3(5, Random.Range(-height, height)); //spike position
       
    }

     void InstantiateObject() 
     {
        Instantiate(spikes, transform.position, transform.rotation);
     }
}
