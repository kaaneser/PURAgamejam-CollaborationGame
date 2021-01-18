using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SkorSayac;

public class wall : MonoBehaviour { 
    
public Transform alt, ust;
public static float hiz;
public Transform baslangicPos;

Vector3 siradakiPos;
 

void Start()
{

    siradakiPos = baslangicPos.position;
}


void Update()
{
    if (transform.position == alt.position)
    {
        siradakiPos = ust.position;

    }

    if (transform.position == ust.position)
    {
        siradakiPos = alt.position;
    }

    transform.position = Vector3.MoveTowards(transform.position, siradakiPos, hiz * Time.deltaTime);
}

}
   
