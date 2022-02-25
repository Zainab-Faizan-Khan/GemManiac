using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityChan;
using System.Runtime.CompilerServices;
public class leveldeath : MonoBehaviour
{
    public GameObject youfell;
    public GameObject leveltimer;
    public GameObject levelmusic;
    public GameObject fade;
    public GameObject timetaken;
    public GameObject totalScore;
    public int totalScored;
    public int timecalc;
    public GameObject unitychan;


    void OnTriggerEnter()
    {
        unitychan.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
        timecalc =GlobalTimer.extendScore * 10;
        timetaken.GetComponent<Text>().text = "Time left " + GlobalTimer.extendScore;

        totalScored = Score.currentScore + timecalc;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        StartCoroutine(Youfelloff());
        

    }
   
    IEnumerator Youfelloff() {
        leveltimer.SetActive(false);
        levelmusic.SetActive(false);
        yield return new WaitForSeconds(1);
        fade.SetActive(true);
        youfell.SetActive(true);
        yield return new WaitForSeconds(2);
        timetaken.SetActive(true);
   
        yield return new WaitForSeconds(1);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(2);
        

    }
    
   
}

