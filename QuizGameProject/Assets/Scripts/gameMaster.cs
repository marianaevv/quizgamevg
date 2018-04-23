using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameMaster : MonoBehaviour {
    public static int points;

    public Text pointsText;
    
	// Update is called once per frame
	void Update () {
        pointsText.text = ("Points:" + " " + points);

	}
    public static void Reset()
    {
        points = 0;
        // scoreText.text = score.ToString ();
    }
}
