using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class promote : MonoBehaviour
{
    public void LoadScene(int SceneIndex){ 
        
            SceneManager.LoadScene(SceneIndex);
        
       
    }
}
