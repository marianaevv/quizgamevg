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
    private static List<Question> unanseredQuestions;
    private Question currentQuestion;
    public Transform canvasRight;
    public Transform canvasWrong;
    public Transform canvasquest;
    public Transform player;


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

        
    }

    public void UserSelectA()
    {
        if (currentQuestion.a)
        {
            if (canvasquest.gameObject.activeInHierarchy == true)
            {
                canvasquest.gameObject.SetActive(false);
                if (canvasRight.gameObject.activeInHierarchy == false)
                {
                    gameMaster.points += 100;
                    canvasRight.gameObject.SetActive(true);

                    StartCoroutine(ExecuteAfterTimeF(1));
                    StartCoroutine(ExecuteAfterTimeP(1));
                    unanseredQuestions.Remove(currentQuestion);
                }
                else
                {
                    canvasRight.gameObject.SetActive(false);
                }
            }
        }
        else
        {
           
            canvasWrong.gameObject.SetActive(true);
            StartCoroutine(ExecuteAfterTime(1));
        }
    }


    public void UserSelectB()
    {
        if (currentQuestion.b)
        {
            if (canvasquest.gameObject.activeInHierarchy == true)
            {
                canvasquest.gameObject.SetActive(false);
                if (canvasRight.gameObject.activeInHierarchy == false)
                {
                    gameMaster.points += 100;
                    canvasRight.gameObject.SetActive(true);

                    StartCoroutine(ExecuteAfterTimeF(1));
                    StartCoroutine(ExecuteAfterTimeP(1));
                    unanseredQuestions.Remove(currentQuestion);
                }
                else
                {
                    canvasRight.gameObject.SetActive(false);
                }
            }
        }
        else
        {
            canvasWrong.gameObject.SetActive(true);
            StartCoroutine(ExecuteAfterTime(1));
        }
    }


    public void UserSelectC()
    {
        if (currentQuestion.c)
        {
            if (canvasquest.gameObject.activeInHierarchy == true)
            {
                canvasquest.gameObject.SetActive(false);
                if (canvasRight.gameObject.activeInHierarchy == false)
                {
                    gameMaster.points += 100;
                    canvasRight.gameObject.SetActive(true);

                    StartCoroutine(ExecuteAfterTimeF(1));
                    StartCoroutine(ExecuteAfterTimeP(1));
                    unanseredQuestions.Remove(currentQuestion);
                }
                else
                {
                    canvasRight.gameObject.SetActive(false);
                }
            }
        }
        else
        {
            canvasWrong.gameObject.SetActive(true);
            StartCoroutine(ExecuteAfterTime(1));
        }
    }



    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        SceneManager.LoadScene("Lose Screen");
        // Code to execute after the delay
    }
    IEnumerator ExecuteAfterTimeF(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        canvasRight.gameObject.SetActive(false);
        // Code to execute after the delay
    }
    IEnumerator ExecuteAfterTimeP(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        Time.timeScale = 1;
        player.GetComponent<playerController>().enabled = true;
        // Code to execute after the delay
    }
}



