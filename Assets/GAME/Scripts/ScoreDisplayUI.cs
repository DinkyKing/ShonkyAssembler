using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplayUI : MonoBehaviour {

    public Text myScore;
    public Text myLives;
   
    void Update()
    {
        
        myScore.text = ScoreBoard.gameScore.ToString();
        myLives.text = ScoreBoard.gameLives.ToString();
    }
}
