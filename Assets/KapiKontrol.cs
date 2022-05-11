using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapiKontrol : MonoBehaviour
{
    public GameObject doorClosed;
    public GameObject doorOpen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<TopHaraket>().anahtarVarmi)
        {
            doorClosed.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
