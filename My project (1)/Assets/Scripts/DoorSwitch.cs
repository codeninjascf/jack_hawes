using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    public GameObject enabledObject;
    public GameObject disabledObject;

    // Start is called before the first frame update
    void Start()
    {
        enabledObject.SetActive(false);
        disabledObject.SetActive(true);

        SwitchEnabled = false;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {

        enabledObject.SetActive(false);
        disabledObject.SetActive(true);

        SwitchEnabled = false;
    }

    public bool SwitchEnabled
    {
        get;
        private set;
    }
    void OnTriggerEnter(Collider other)
    {
        enabledObject.SetActive(true);
        disabledObject.SetActive(false);

        SwitchEnabled = true;
    }
    void OnTriggerStay(Collider other)
    {
        enabledObject.SetActive(true);
        disabledObject.SetActive(false);

        SwitchEnabled = true;
    }

}

