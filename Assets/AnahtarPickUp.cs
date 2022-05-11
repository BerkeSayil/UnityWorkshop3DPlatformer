using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnahtarPickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<TopHaraket>().anahtarVarmi = true;
        
        Destroy(gameObject);
    }

}
