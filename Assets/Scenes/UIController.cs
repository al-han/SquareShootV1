using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    GameController gameController;
    private void Start() {
        // gameController = GameObject.FindGameObjectsWithTag("gameControl").GetComponent<>;
        //gameController = GameObject.FindGameObjectsWithTag("GameController");
        //this was suppose to handle score but I was unable to do so . 
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }
    public void UpdateScore() {
        scoreText.text = gameController.score.ToString();
    }
}
