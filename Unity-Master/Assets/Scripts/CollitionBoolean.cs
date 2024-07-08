using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionBoolean : MonoBehaviour
{
   
   public bool secondLocation = false;


   void OnTriggerEnter(Collider other)
      {

      Debug.Log(other.name);
      if (other.gameObject.tag == "SecondLocation"){
        
         secondLocation = true;
         Debug.Log("second location");
      } 

      if (other.gameObject.tag == "FirstLocation"){
            secondLocation = false;
            Debug.Log("FirstLocation");
      }
    }

}
