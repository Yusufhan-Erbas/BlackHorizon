using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{

    private Rigidbody2D rb;
    public float Ax;
    public float Ay;
    public float hiz = 35f;

    public Camera kam;
    private Vector2 FareKonum;

   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

 
    void Update()
    {
        Ax = Input.GetAxisRaw("Horizontal");
        Ay = Input.GetAxisRaw("Vertical");

        FareKonum = kam.ScreenToWorldPoint(Input.mousePosition);

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(Ax, Ay, 0) * hiz * Time.fixedDeltaTime * 10;

        Vector2 bak = FareKonum - rb.position;
        float aci = Mathf.Atan2(bak.y, bak.x) * Mathf.Rad2Deg - 90;
        rb.rotation = aci;
    }
}
