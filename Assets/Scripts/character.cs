using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class character : MonoBehaviour
{
    public AudioSource eatSound;
    public float velocity;
    public Transform foodd;
    int score;
    public TextMeshProUGUI score_Text;

    void Update()
    {
        score_Text.text = "Score: " + score;
        movementCharacter();
    }

    void movementCharacter(){

        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-velocity * Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(velocity * Time.deltaTime,0,0);
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        float xPosition = Random.Range(-5f,5f);

        if(col.gameObject.tag=="food"){
            foodd.position = new Vector3(xPosition,7f,0f);
            eatSound.Play();
            score+=1;
        }
    
    } 
} 

