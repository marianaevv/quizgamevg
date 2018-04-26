using UnityEngine;
using UnityEngine.SceneManagement;		// Requiered to switch scenes
using System.Collections;


public class LevelManager : MonoBehaviour {

    public void LoadLevel(string name)
    {
        Debug.Log("New Level load: " + name);
        Application.LoadLevel(name);
    }
  
    public  void LoadNextLevel()
    {

        StartCoroutine(ExecuteAfterTime(2));

    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSecondsRealtime(time);
      //  Application.LoadLevel(Application.loadedLevel + 1);
        SceneManager.LoadScene(Application.loadedLevel + 1);
        // Code to execute after the delay
    }

}
