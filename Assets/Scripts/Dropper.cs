using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] int Timer1st = 3;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
    if(Time.time > Timer1st)
        {
        renderer.enabled = true;
        rigidbody.useGravity = true;   
        Debug.Log("its been 3 seconts yo");
        }
    }    
}



