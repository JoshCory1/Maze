using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
   private void OnCollisionEnter(Collision other)
   {
   GetComponent<MeshRenderer>().material.color = Color.white;
   Debug.Log("You Win!!!!!!!!");
   if(other.gameObject.tag == "Cheese")
      {
         Scorer.GetComponent<Scorer>().EndGame();
      }
   }
}
