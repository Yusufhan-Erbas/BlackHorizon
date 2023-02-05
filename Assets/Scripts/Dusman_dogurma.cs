using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman_dogurma : MonoBehaviour
{

    public GameObject dusman;

    public Transform t1;
    public Transform t2;
    public Transform t3;
    public Transform t4;

    public float Sayac = 2f;
    private float _sayac = 0;

    public float MaxDusman = 6;
    public float dusmanSayisi = 0;

    void Start()
    {
       
    }

    
    void Update()
    {
        if(_sayac > 0)
        {
            _sayac -= Time.deltaTime;
        }
        else if(_sayac <= 0)
        {
             Dogur();
            _sayac = Sayac;
            //Debug.Log("hahaha");
            //Debug.Log(dusmanSayisi.ToString());
        }


    }

    public void dsge()
    {
        dusmanSayisi--;
        //Debug.Log(dusmanSayisi.ToString());
    }

    public void dsga()
    {
        dusmanSayisi++;
        //Debug.Log(dusmanSayisi.ToString());
    }

    void Dogur()
    {
        if (dusmanSayisi < MaxDusman)
        {
            int r = Random.Range(0, 4);
            if (r == 0)
            {
                //Debug.Log(dusman.name);
                GameObject a = Instantiate(dusman, t1.position, t1.rotation);
                dsga();
            }
            else if (r == 1)
            {
                //Debug.Log(dusman.name);
                Instantiate(dusman, t2.position, t2.rotation);
                dsga();
            }
            else if (r == 2)
            {
                //Debug.Log(dusman.name);
                Instantiate(dusman, t3.position, t3.rotation);
                dsga();
            }
            else if (r == 3)
            {
                //Debug.Log(dusman.name);
                Instantiate(dusman, t4.position, t4.rotation);
                dsga();
            }
        }
        //Debug.Log("???");

    }

}
