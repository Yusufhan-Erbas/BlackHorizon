using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OlumManger : MonoBehaviour
{


    public Canvas c;
    public Text t;

    void Start()
    {
        this.gameObject.SetActive(false);
    }

   
    void Update()
    {
        
    }

    public void CanvasActivate(int skor)
    {
        int a = Random.Range(4, 20);
        c.gameObject.SetActive(false);
        this.gameObject.SetActive(true);
        t.text = a.ToString();
    }

    public void AnaM()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void AnaG()
    {
        SceneManager.LoadScene("MainGame");
    }
}
