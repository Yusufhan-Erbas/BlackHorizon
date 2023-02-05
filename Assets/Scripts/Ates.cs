using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ates : MonoBehaviour
{
    public GameObject mermi;
    public Transform t;
    private Vector3 _t;
    public float MermiHizi = 50;


    void Start()
    {
      
    }

    
    void Update()
    {

        _t = new Vector3(t.position.x, t.position.y, 3);
        if (Input.GetButtonDown("Fire1"))
        {
            // Debug.Log("Black Star");
            Fire();
        }
    }



    void Fire()
    {
        GameObject _mermi = Instantiate(mermi, _t, t.rotation) as GameObject;
        Rigidbody2D _rb = _mermi.GetComponent<Rigidbody2D>();
        _rb.AddForce(t.up * MermiHizi, ForceMode2D.Impulse);
    }
}
