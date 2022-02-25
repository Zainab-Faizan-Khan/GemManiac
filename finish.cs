using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityChan;
using System.Runtime.CompilerServices;

public class finish : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject finalgem;
    public GameObject timetaken;
    public GameObject totalScore;
    public GameObject fade;
    public GameObject text;
    public GameObject score;
    public GameObject button;
    public int timecalc;
    public int scoreCalc;
    public int totalScored;
    public GameObject unitychan;

    void OnTriggerEnter()
    {
        timecalc = GlobalTimer.extendScore * 10;
        timetaken.GetComponent<Text>().text = "Time left: " + GlobalTimer.extendScore ;
        score.GetComponent<Text>().text = "Score: " + Score.currentScore;
        totalScored = Score.currentScore + timecalc;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        unitychan.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
        Destroy(finalgem.gameObject);
        StartCoroutine(Youfinished());
    }
    IEnumerator Youfinished()
    {
        
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        
        fade.SetActive(true);
        text.SetActive(true);
        score.SetActive(true);
        timetaken.SetActive(true);
        totalScore.SetActive(true);
        button.SetActive(true);
        yield return new WaitForSeconds(2f);
        


    }
}
