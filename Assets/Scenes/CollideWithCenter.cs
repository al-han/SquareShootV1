using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithCenter : MonoBehaviour
{
    // Start is called before the first frame update
    // old file, doesn't belong
    void OnCollisionEnter2D(Collision2D coll) {
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.CompareTag("CenterSquare")) {
           Destroy(collidedWith);
            
        }
    }  
    // Update is called once per frame
    void Update()
    {
        
    }
}
