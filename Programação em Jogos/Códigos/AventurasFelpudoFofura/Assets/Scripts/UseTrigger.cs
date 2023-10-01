using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTrigger: MonoBehaviour {
    
 void OnTriggerEnter2D(Collider2D collisionInfo){
      if(collisionInfo.gameObject.tag == "Player")
        collisionInfo.gameObject.GetComponent<Renderer>().material.color=Color.green;
 }

 void OnTriggerStay2D(Collider2D collisionInfo){
    if(collisionInfo.gameObject.tag == "Player")
      collisionInfo.gameObject.GetComponent<Renderer>().material.color=Color.red;
 }

 void OnTriggerExit2D(Collider2D collisionInfo){
    if(collisionInfo.gameObject.tag == "Player")
      collisionInfo.gameObject.GetComponent<Renderer>().material.color=Color.blue;
 }


}