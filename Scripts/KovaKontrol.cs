using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KovaKontrol : MonoBehaviour
{
    public GameObject menuEkrani, oyunEkrani;
    Animator karakterAnim;
    Rigidbody2D rb;
    float yatay = 0;
    Vector3 vector;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        karakterAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            Pause();
        }

        yatay = Input.GetAxisRaw("Horizontal");
        if (yatay == 0)
        {
            karakterAnim.SetTrigger("goIdle");
        }
        else if (yatay == 1)
        {
            karakterAnim.SetTrigger("goRight");
        }
        else if (yatay == -1)
        {
            karakterAnim.SetTrigger("goLeft");
        }
        vector = new Vector3(yatay * 5, rb.velocity.y, 0);
        rb.velocity = vector;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        oyunEkrani.SetActive(false);
        menuEkrani.SetActive(true);
        GameManager.Instance.isGame_stop = true;
    }
}
