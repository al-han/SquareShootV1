using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Limiter : MonoBehaviour
{
    // Start is called before the first frame update
    public static float greaterX = 20f;
    public static float greaterY = 20f;
    public static float lowerX = -20f;
    public static float lowerY = -20f;
    public static float timer = 1;

    // Update is called once per frame
    //this checks if a square goes out of bounds and despawns it
    void Update()
    {
         if(transform.position.x > greaterX){
            //Destroy(this.GameObject);
           
            Destroy(this.gameObject);
        }    
       else if(transform.position.y > greaterY) {
            Destroy(this.gameObject);
        }    
        else if(transform.position.x < lowerX) {
            Destroy(this.gameObject);
        } 
        else if(transform.position.y < lowerY) {
            Destroy(this.gameObject);
        } 
    }
}
