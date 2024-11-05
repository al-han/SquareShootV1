using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    // another aspect to getting the score to work didn't work.
    public int score {get; private set;}

    public void IncrementScore() {
        
        score++;
        Debug.Log(score);
    }   
}
