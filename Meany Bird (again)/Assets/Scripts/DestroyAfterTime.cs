using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Default Destruction Time")]
    public float timeDestruction;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", timeDestruction);
    }

    // Update is called once per frame
    void DestroyObject()
    {
     Destroy(gameObject);
    }

    
}

