using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CategorieManager : MonoBehaviour
{
    public Transform canvasquestMat;
    public Transform canvasquestHist;
    public Transform canvasquestIng;
    public Transform canvasquestBon;
    public Transform canvasquestGeo;
    public Transform canvascat;
  //  public Transform player;

    //  public Categories[] cat;
    //  private static List<Categories> unanseredQuestions;
    //private Categories currentQuestion;
    //  private Answers ans;

    //   [SerializeField]
    // private Text namec1, namec2, namec3, namec4, namec5;

    /*  private void Start()
      {

          if (unanseredQuestions == null || unanseredQuestions.Count == 0)
          {
              unanseredQuestions = cat.ToList<Categories>();
          }
          SetCurrentQuestion();
      }

     /* void SetCurrentQuestion()
      {
          int randomQuestionIndex = Random.Range(0, unanseredQuestions.Count);
          currentQuestion = unanseredQuestions[randomQuestionIndex];

          namec1.text = currentQuestion.c1;
          namec2.text = currentQuestion.c2;
          namec3.text = currentQuestion.c3;
          namec4.text = currentQuestion.c4;
          namec5.text = currentQuestion.c5;
          unanseredQuestions.RemoveAt(randomQuestionIndex);
      }
      IEnumerator TransitionToNextQuestion()
      {
          unanseredQuestions.Remove(currentQuestion);
          yield return new WaitForSeconds(timeBetweenQuestion);

          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      }*/

    public void UserSelectMatematicas()
    {
        if (canvasquestMat.gameObject.activeInHierarchy == false)
        {
            canvascat.gameObject.SetActive(false);
            canvasquestMat.gameObject.SetActive(true);
        }
        else
        {
            canvasquestMat.gameObject.SetActive(false);
        }
    }
    public void UserSelectIngles()
    {
        if (canvasquestIng.gameObject.activeInHierarchy == false)
        {
            canvascat.gameObject.SetActive(false);
            canvasquestIng.gameObject.SetActive(true);
        }
        else
        {
            canvasquestIng.gameObject.SetActive(false);
        }
    }
    public void UserSelectHistoria()
    {
        if (canvasquestHist.gameObject.activeInHierarchy == false)
        {
            canvascat.gameObject.SetActive(false);
            canvasquestHist.gameObject.SetActive(true);
        }
        else
        {
            canvasquestHist.gameObject.SetActive(false);
        }
    }

    public void UserSelectBonus()
    {
        if (canvasquestBon.gameObject.activeInHierarchy == false)
        {
            canvascat.gameObject.SetActive(false);
            canvasquestBon.gameObject.SetActive(true);
        }
        else
        {
            canvasquestBon.gameObject.SetActive(false);
        }
    }

    public void UserSelectGeografía()
    {
        if (canvasquestGeo.gameObject.activeInHierarchy == false)
        {
            canvascat.gameObject.SetActive(false);
            canvasquestGeo.gameObject.SetActive(true);
        }
        else
        {
            canvasquestGeo.gameObject.SetActive(false);
        }
    }
}
