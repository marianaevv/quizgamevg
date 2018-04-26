using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {
    private void OnTriggerEnter2DD(Collider2D colli)
    {
        if (colli.tag == "Player")
            Destroy(gameObject);
        SceneManager.LoadScene("Win Screen");
    }

}
