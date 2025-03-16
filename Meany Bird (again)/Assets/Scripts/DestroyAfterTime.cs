using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Default Destruction Time")]
    Public float timeDestruction;

    // Start is called before the first frame update
    void Start()
    {
      Invoke("DestroyObject",TimeToDestruction)
    }

    // Update is called once per frame
    void DestroyObject()
    {
     Destroy(gameObject);
    }

    
}

