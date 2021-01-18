using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorSayac : MonoBehaviour
{
    public static int skor = 0;
    Text skor_sayac;

    void Start()
    {
        skor_sayac = GetComponent<Text>();
    }

    void Update()
    {
        skor_sayac.text = skor.ToString();
    }
}
