using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{  
    float moveSpeed = 10f;
    void Start()
    {
      PrintInstructions();  
    }

    // Update is called once per frame
    // Time.deltaTime
    void Update()
    {
        MovePlayer();
    }
    void PrintInstructions()
    {
        Debug.Log("Welcome to the game, Move with (WASD)");
        Debug.Log("get the mouse to the end of maze, Don't hit stuff sfuff is bad");
        Debug.Log("Good luck");

    }
    void MovePlayer()
    {
         // transform.Translate(xValue,yValue,zValue);
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
    
}
