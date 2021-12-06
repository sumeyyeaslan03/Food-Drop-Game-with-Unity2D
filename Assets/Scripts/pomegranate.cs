using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pomegranate : MonoBehaviour
{   
     public Transform food;
    void OnCollisionEnter2D(Collision2D collision){
        float xPosition = Random.Range(-5f,5f);

        if(collision.gameObject.tag=="ground"){
           food.position = new Vector3(xPosition,7f,0f);        
        }
    }
}
