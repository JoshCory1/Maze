using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
  int Hits = 0;
  void OnCollisionEnter(Collision other) 
  {
  Hits++;
  Debug.Log("you have bumped into stuff:" + Hits);
  }
}