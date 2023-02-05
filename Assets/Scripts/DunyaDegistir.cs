using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DunyaDegistir : MonoBehaviour
{
    private Camera kam;
    private int i = 0;

    public LayerMask lm1;
    public LayerMask lm2;
    public LayerMask lm3;
    public LayerMask lm4;

    void Start()
    {
        kam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space))
        {
            Degistir();
        }
    }

    void Degistir()
    {
        switch (i)
        {
            case 0:
                kam.cullingMask -= lm4;
                kam.cullingMask += lm1;
                i++;
                return;
            case 1:
                kam.cullingMask -= lm1;
                kam.cullingMask += lm2;
                i++;
                return;
            case 2:
                kam.cullingMask -= lm2;
                kam.cullingMask += lm3;
                i++;
                return;
            case 3:
                kam.cullingMask -= lm3;
                kam.cullingMask += lm4;
                i = 0;
                return;
        }
    }
}
