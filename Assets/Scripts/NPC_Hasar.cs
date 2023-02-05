using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Hasar : MonoBehaviour
{
    public float MaxCan = 4;
    public float can;
    public GameObject ddo1;
    public GameObject ddo2;
    public GameObject ddo3;
    public GameObject ddo4;
    public GameObject oyuncu;
    void Start()
    {
        can = MaxCan;
        ddo1 = GameObject.FindGameObjectWithTag("ddo1");
        ddo2 = GameObject.FindGameObjectWithTag("ddo2");
        ddo3 = GameObject.FindGameObjectWithTag("ddo3");
        ddo4 = GameObject.FindGameObjectWithTag("ddo4");

        oyuncu = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(can <= 0)
        {
            if (this.tag == "u1")
                ddo1.GetComponent<Dusman_dogurma>().dsge();
            if (this.tag == "u2")
                ddo2.GetComponent<Dusman_dogurma>().dsge();
            if (this.tag == "u3")
                ddo3.GetComponent<Dusman_dogurma>().dsge();
            if (this.tag == "u4")
                ddo4.GetComponent<Dusman_dogurma>().dsge();
            oyuncu.GetComponent<Hasar>().skora();
            Destroy(gameObject);

        }
    }

    public void OnCollisionEnter2D(Collision2D diger)
    {
        if (diger.gameObject.tag == ("Player"))
        {
            oyuncu.GetComponent<Hasar>().hasar();
            Destroy(gameObject);
        }
        if (this.tag == "u1")
            ddo1.GetComponent<Dusman_dogurma>().dsge();
        if (this.tag == "u2")
            ddo2.GetComponent<Dusman_dogurma>().dsge();
        if (this.tag == "u3")
            ddo3.GetComponent<Dusman_dogurma>().dsge();
        if (this.tag == "u4")
            ddo4.GetComponent<Dusman_dogurma>().dsge();
    }


    public void Hasaral()
    {
        can--;
    }
}
