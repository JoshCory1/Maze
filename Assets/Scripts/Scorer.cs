using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
  void EndGame()
  {
    Player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositrion;
    hasGameStrarted = true;
    inMenuUI.gameObject.SetActive(false);
    inGameUI.gameObject.SetActive(false);
    gameOverUI.gameObject.SetActive(true);
  }
  
  int Hits = 0;
  void OnCollisionEnter(Collision other) 
  {
    if(other.gameObject.tag != "Hit" && other.gameObject.tag != "Cheese")
    {
      Hits++;
      Debug.Log("you have bumped into stuff:" + Hits);
    }
  }
}
