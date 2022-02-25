using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject finalgem;
    public GameObject Key;
    void OnTriggerEnter() {
        finalgem.SetActive(true);
        Destroy(Key.gameObject);

    }
}
