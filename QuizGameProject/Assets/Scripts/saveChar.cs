using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saveChar : MonoBehaviour {


    //Method that load the next level when the player collider interacts with the other object's collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        Destroy(gameObject);
        SceneManager.LoadScene("Question");
    }

}

