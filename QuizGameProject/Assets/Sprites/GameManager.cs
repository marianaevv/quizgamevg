using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Question[] questions;
    //public Answers[] answers;
    private static List<Question> unanseredQuestions;
    private Question currentQuestion;
    //  private Answers ans;

    [SerializeField]
    private Text factText, ansa, ansb, ansc;

    [SerializeField]
    private float timeBetweenQuestion = 3f;
    private void Start()
    {

        if (unanseredQuestions == null || unanseredQuestions.Count == 0)
        {
            unanseredQuestions = questions.ToList<Question>();
        }
        SetCurrentQuestion();
    }

    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unanseredQuestions.Count);
        currentQuestion = unanseredQuestions[randomQuestionIndex];

        factText.text = currentQuestion.fact;
        ansa.text = currentQuestion.aa;
        ansb.text = currentQuestion.bb;
        ansc.text = currentQuestion.cc;
        unanseredQuestions.RemoveAt(randomQuestionIndex);
    }
    IEnumerator TransitionToNextQuestion()
    {
        unanseredQuestions.Remove(currentQuestion);
        yield return new WaitForSeconds(timeBetweenQuestion);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelectA()
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
    public void UserSelectB()
    {
        if (!currentQuestion.b)
        {
            Debug.Log("CORRECT");
        }
        else
        {
            Debug.Log("WRONG");
        }
    }
    public void UserSelectC()
    {
        if (!currentQuestion.c)
        {
            Debug.Log("CORRECT");
        }
        else
        {
            Debug.Log("WRONG");
        }
    }

}