using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class saveChar : MonoBehaviour
{
    public Transform canvas;

        private void OnTriggerEnter2D(Collider2D collision)
         {

             if(collision.tag == "Player")
             Destroy(gameObject);
             if(canvas.gameObject.activeInHierarchy == false)
             {
                 canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
          //  player.GetComponent<playerController>().enabled = false;
             }
             else
             {
                 canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
           // player.GetComponent<playerController>().enabled = true;
        }
         }

}

