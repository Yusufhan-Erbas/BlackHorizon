using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 public class KameraTakip : MonoBehaviour
{

    public GameObject Oyuncu;
    public float hiz = 100;
    void Start()
    {

        Oyuncu = GameObject.FindGameObjectWithTag("Player");
        transform.position = new Vector3(transform.position.x, transform.position.y, -99);
    }

    void Update()
    {
        Vector3 konum = new Vector3(Oyuncu.transform.position.x, Oyuncu.transform.position.y, -99);
        //transform.position = Vector2.MoveTowards(transform.position, konum, hiz*Time.deltaTime);
        transform.position = new Vector3(Oyuncu.transform.position.x, Oyuncu.transform.position.y, 0);
    }

}
