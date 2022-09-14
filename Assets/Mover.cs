using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{  
    float moveSpeed = 100f;
    void Start()
    {
        
    }

    // Update is called once per frame
    // Time.deltaTime
    void Update()
    {
        // transform.Translate(xValue,yValue,zValue);
    
    float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
    float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
    transform.Translate(xValue,0,zValue);
    }
}
