using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class oyuniciArayuz : MonoBehaviour
{
    public GameObject menuEkrani, oyunEkrani;

    public void menuButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void replayButton()
    {
        Time.timeScale = 1;
        SkorSayac.skor = 0;
        SceneManager.LoadScene(1);
    }

    public void devamEt()
    {
        menuEkrani.SetActive(false);
        oyunEkrani.SetActive(true);
        Time.timeScale = 1;

        GameManager.Instance.isGame_stop = false;
    }

}
