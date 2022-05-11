using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopTakip : MonoBehaviour
{
    public GameObject top;
    private Vector3 topVector;

    private Vector3 kameraFarki;
    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
        topVector = top.transform.position;
        kameraFarki = new Vector3(topVector.x, topVector.y + 2 , topVector.z - 4);
        
        gameObject.transform.position = kameraFarki;

    }
}
