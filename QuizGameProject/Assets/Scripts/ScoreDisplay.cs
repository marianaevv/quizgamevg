using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
  
	// Use this for initialization
	void Start () {
		Text scoreText = GetComponent<Text> ();
        scoreText.text = gameMaster.points.ToString();
        // scoreText.text = ScoreKeeper.score.ToString ();
        gameMaster.Reset();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
