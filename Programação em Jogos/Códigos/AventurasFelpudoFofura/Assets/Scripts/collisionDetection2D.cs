using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetection2D : MonoBehaviour{
    
    private void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("Colisão detectada com o objeto: " + collision.gameObject.name);
    }

}