using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
   private void OnCollisionEnter(Collision other)
   {
   GetComponent<MeshRenderer>().material.color = Color.white;
   Debug.Log("The mose is full!");
   }
}
