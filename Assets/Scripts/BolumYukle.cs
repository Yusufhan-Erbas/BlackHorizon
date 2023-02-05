using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BolumYukle : MonoBehaviour 
{
    
    public void SceneLoad(string _scene)
    {
        SceneManager.LoadScene(_scene);
    }
    
}
