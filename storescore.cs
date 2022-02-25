using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oksc : MonoBehaviour
{
    public GameObject good;
    public GameObject enter;
    public GameObject name;
    public GameObject but;
    public GameObject but1;
    public GameObject label;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    public void ok() {
        but1.SetActive(true);
        good.SetActive(false);
        enter.SetActive(false);
        name.SetActive(false);
        Destroy(but.gameObject);
        text1.SetActive(true);
        label.SetActive(true);
        text2.SetActive(true);
        text3.SetActive(true);

    }
}
