using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi : MonoBehaviour
{




    void Start()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        try
        {
            collision.gameObject.GetComponent<NPC_Hasar>().Hasaral();
            Destroy(gameObject);
        }
        catch
        {
            Debug.Log("sorun yok aq");
        }
        Destroy(gameObject);
    }
}
