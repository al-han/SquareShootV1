using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using Unity.VisualScripting;



//using System.Numerics;
using UnityEngine;
using UnityEngine.Events;
//this is suppose to handle action done by the squares that shoot from the center square. Also collisions. 
public class ProjectileSquare : MonoBehaviour
{
   
    // Start is called before the first frame update
    public GameObject ProjectileSquareObject;
    //public Vector2 velocity;
    public Transform SquareSpawnPoint;
    public UnityEvent scoreCollionGetter;
    //public Vector2 hello;
    public float force=1000f;
    public GameAudio1 killme;


    private void Start() {
        scoreCollionGetter.AddListener(GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().IncrementScore);
        scoreCollionGetter.AddListener(GameObject.FindGameObjectWithTag("UIController").GetComponent<UIController>().UpdateScore);
    }
    void ShootSquares(Vector2 direction) {
        GameObject newProjectile = Instantiate(ProjectileSquareObject, transform.position, Quaternion.identity); //transform.rotation);
        //newProjectile.GetComponent<Rigidbody2D>().velocity = newProjectile.GetComponent
        Rigidbody2D projSquareRb = newProjectile.GetComponent<Rigidbody2D>();    
        if (projSquareRb != null) {
            projSquareRb.AddForce(direction * force);
            
        }
    }
    void OnCollisionEnter2D(Collision2D coll) {
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.CompareTag("AttackSquare")) {
          //  killme.PlayThisSound();
           // scoreCollionGetter.Invoke();
            Destroy(collidedWith);
            
        }
        //  if(collidedWith.CompareTag("ProjectileSquare")) {
        //     scoreCollionGetter.Invoke();
        //     Destroy(collidedWith);

        // }
        Destroy(gameObject);
    }  
    public void TestMethod() {
        print("Hello WOrld");
    }
    void Update() {
        if(Input.GetKeyDown(KeyCode.D)) {
            ShootSquares(Vector2.right);
            Debug.Log(gameObject.tag);
           
        
        }
        else if(Input.GetKeyDown(KeyCode.W)) {
            ShootSquares(Vector2.up);
           
        }
        else if(Input.GetKeyDown(KeyCode.S)) {
            ShootSquares(Vector2.down);
            
        }
        else if(Input.GetKeyDown(KeyCode.A)) {
            ShootSquares(Vector2.left);
            
        }
        }
    }

