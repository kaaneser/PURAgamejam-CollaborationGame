using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_oneMovement : MonoBehaviour
{
    public Transform sag, sol;
    public static float hiz;
    public Transform baslangicPos;

    Vector3 siradakiPos;


    void Start()
    {

        siradakiPos = baslangicPos.position;
    }


    void Update()
    {
        if (SkorSayac.skor < 10)
        {
            if (SkorSayac.skor == 0)
            {
                hiz = 0;
            }
            else if (SkorSayac.skor >= 3)
            {
                hiz = 0.5f * SkorSayac.skor;
            }
        }

        if (transform.position == sag.position)
        {
            siradakiPos = sol.position;

        }

        if (transform.position == sol.position)
        {
            siradakiPos = sag.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, siradakiPos, hiz * Time.deltaTime);
    }
}
