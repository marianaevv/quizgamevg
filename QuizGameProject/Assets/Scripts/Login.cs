using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour {

    //Variables publicas
    public string currentMenu = "Login";


    //Variables estaticas
    public static string Email = "";
    public static string Password = "";


    private string CreateAccountUrl = "";
    private string LoginUrl = "";

    public float x;
    public float y;
    public float Width;
    public float Height;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    /*
    private void OnGUI(){
        if (currentMenu == "Login")
        {
            LogInGUI();
        }
        else if (currentMenu == "CreateAccount")
            CreateAccountGUI();
    }

    IEnumerator TransitionToNextScene()
    {
        unanseredQuestions.Remove(currentQuestion);
        yield return new WaitForSeconds(timeBetweenQuestion);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelectLoginButton()
    {
        if (currentQuestion.a)
        {
            Debug.Log("CORRECT");
        }
        else
        {
            Debug.Log("WRONG");
        }
        StartCoroutine(TransitionToNextQuestion());

    }

    /*

    void LogInGUI() {
    }
    void CreateAccountGUI(){
        if (ConfirmPass == CPass)
    }

    */
}
