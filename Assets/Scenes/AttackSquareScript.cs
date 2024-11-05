using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AttackingScript : MonoBehaviour
{
    // this script is suppose to handle some actions done by the attacking squares. 
    public GameObject AttackSquareObject;
    public Transform AttackSpawnPointNorth;
    public Transform AttackSpawnPointEast;
    public Transform AttackSpawnPointWest;
    public Transform AttackSpawnPointSouth;
    
    private List<Transform> listOfSpawn=new List<Transform>(); 
    public float force = 100f;
    public float timePassed = 0f;

    void Start()
    {
        listOfSpawn.Add(AttackSpawnPointNorth);
        listOfSpawn.Add(AttackSpawnPointEast);
        listOfSpawn.Add(AttackSpawnPointWest);
        listOfSpawn.Add(AttackSpawnPointSouth);
        StartCoroutine(MyCoroutine());
    }

    // Update is called once per frame
    float second=0f;
    IEnumerator MyCoroutine() {
        Debug.Log(Time.frameCount);
        yield return new WaitForSecondsRealtime(1f);;
        Debug.Log(Time.time);
    }
    
    void Update()
    {
        //  Debug.Log(Time.time);
        int random =Random.Range(1,5);
        timePassed += Time.deltaTime;
        if(timePassed > 1f) {
            if(random ==1) {
                attackingSquares(Vector2.left,AttackSpawnPointEast);
            }
             if(random == 2) {
                 attackingSquares(Vector2.down,AttackSpawnPointNorth);
             }
             if(random == 3) {
                attackingSquares(Vector2.right, AttackSpawnPointWest);
             }
            if(random == 4) {
                attackingSquares(Vector2.up,AttackSpawnPointSouth);
            }

            timePassed =0f;
        }
        //squares attack randomly from this point
    }

    //squares move from this code
    void attackingSquares(Vector2 direction, Transform inputTransform) {
        GameObject newProjectile = Instantiate(AttackSquareObject, inputTransform.position, Quaternion.identity); //transform.rotation);
        //newProjectile.GetComponent<Rigidbody2D>().velocity = newProjectile.GetComponent
        Rigidbody2D AttackSquareRb = newProjectile.GetComponent<Rigidbody2D>();   

        if (AttackSquareRb != null) {
            AttackSquareRb.AddForce(direction * force);
        }

    }

}
