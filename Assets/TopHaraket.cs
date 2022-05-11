using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHaraket : MonoBehaviour
{
    private Rigidbody topRB;
    private float minZiplamaArasi = 1;
    private float zamanTakip;

    public bool anahtarVarmi;
    
    // Start is called before the first frame update
    void Start()
    {
        topRB = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            topRB.AddForce(Vector3.forward, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            topRB.AddForce(Vector3.back, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            topRB.AddForce(Vector3.left, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            topRB.AddForce(Vector3.right, ForceMode.Force);
        }
        

        if ((zamanTakip > minZiplamaArasi) & Input.GetKey(KeyCode.Space))
        {
            topRB.AddForce(Vector3.up * 4 , ForceMode.Impulse);
            zamanTakip = 0;
        }
            
        zamanTakip = zamanTakip + Time.deltaTime;


    }
}
