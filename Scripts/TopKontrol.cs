using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static SkorSayac;
using static player_oneMovement;
using static wall;

public class TopKontrol : MonoBehaviour
{
    public GameObject oyunEkrani, gameoverEkrani, scoreboard;
    public Transform ballParent;
    public GameObject top;
    public GameObject orta_Duvar;
    public float guc;
    public Transform firlatmaNoktasi;
    Rigidbody2D topRig;
    bool firlatildiMi = true;
    public AudioSource source;
    public AudioClip basketball_throw, gameover, score;

    void Start()
    {
        topRig = top.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(firlatildiMi)
        {
            topYonu();

            if (Input.GetMouseButtonDown(0) && !GameManager.Instance.isGame_stop)
            {
                transform.SetParent(null);
                topRig.gravityScale = 1;
                topRig.velocity = transform.right * guc;
                firlatildiMi = false;
                Debug.Log("Girdi");
                source.PlayOneShot(basketball_throw);
            }
        }
    }

    void topYonu()
    {
        Vector2 topPos = transform.position;
        Vector2 farePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 yon = farePos - topPos;
        transform.right = yon;
    }

    void Olustur()
    {
        transform.SetParent(ballParent);
        transform.position = new Vector2(firlatmaNoktasi.position.x, firlatmaNoktasi.position.y);
        transform.rotation = firlatmaNoktasi.rotation;
        topRig.constraints = RigidbodyConstraints2D.None;
        firlatildiMi = true;
        topRig.gravityScale = 0;
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "kova")
        {
            topRig.constraints = RigidbodyConstraints2D.FreezeAll;
            SkorSayac.skor += 1;

            if(SkorSayac.skor >= 3)
            {
                player_oneMovement.hiz = 0.5f * SkorSayac.skor;

                if (SkorSayac.skor >= 10)
                {
                    float yEksen = Random.Range(-0.75f, 4.15f);
                    orta_Duvar.transform.position = new Vector2(0, yEksen);
                }
            }

            Olustur();
            source.PlayOneShot(score);
        }
        else if (col.tag == "gameOver")
        {
            Destroy(top);
            gameOver();
            source.PlayOneShot(gameover);
        }
    }

    public void gameOver()
    {
        Time.timeScale = 0;
        oyunEkrani.SetActive(false);
        gameoverEkrani.SetActive(true);
    }
}
