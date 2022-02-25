using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTimer : MonoBehaviour
{


    public GameObject timeDisplay02;
    public bool isTakingTime = false;
    public int theSeconds = 150;
    public static int extendScore;
    public GameObject gameOver;

    void Update()
    {
        if (theSeconds > 0)
        {
            extendScore = theSeconds;
            if (isTakingTime == false)
            {
                StartCoroutine(SubtractSecond());
            }
        }
        else if (theSeconds <= 0)
        {
            GameOver();
            theSeconds = 0;
        }

    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        SceneManager.LoadScene(2);
    }
    IEnumerator SubtractSecond()
    {
        if (theSeconds > 0)
        {
            isTakingTime = true;
            theSeconds -= 1;

            timeDisplay02.GetComponent<Text>().text = "" + theSeconds;
            yield return new WaitForSeconds(1);
            isTakingTime = false;

        }
    }

}
