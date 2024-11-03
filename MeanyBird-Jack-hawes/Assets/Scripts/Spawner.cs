using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Spikes;

    public float height;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", 1f, 4f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(5, Random.Range(-height, height), 0);    
    }

    void InstantiateObjects()
    {
        Instantiate(Spikes, transform.position, transform.rotation);
    }
}
