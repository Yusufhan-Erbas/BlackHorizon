using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Hareket : MonoBehaviour
{
    

    private Rigidbody2D rb;
    public GameObject oyuncu;
    public int hiz = 2;

    private Vector2 hareket;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        oyuncu = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
        Vector3 yon = oyuncu.transform.position - transform.position;
        float aci = Mathf.Atan2(yon.y, yon.x) * Mathf.Rad2Deg + 90;
        rb.rotation = aci;
        yon.Normalize();
        hareket = yon;
    }

    private void FixedUpdate()
    {
       karakterHareket(hareket);
    }

    void karakterHareket(Vector2 _yon)
    {
        rb.MovePosition((Vector2)transform.position + (_yon * Time.deltaTime * hiz));
    }
}
