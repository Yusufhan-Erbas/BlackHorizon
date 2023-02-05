using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hasar : MonoBehaviour
{
    public float maxcan = 5;
    public float can = 0;
    public Text text;
    public GameObject olum;
    public int skor;

   
    void Start()
    {
        can = maxcan;
    }

    
    void Update()
    {
        if(can <= 0)
        {
            olum.GetComponent<OlumManger>().CanvasActivate(skor);
            text.text = "<3 = 0";
            Destroy(gameObject);
            
        }
        else
        {
            text.text ="<3 = "  + can.ToString();
        }

    }

    public void hasar()
    {
        can--;
    }

    public void skora()
    {
        skor += 10;
    }

}
