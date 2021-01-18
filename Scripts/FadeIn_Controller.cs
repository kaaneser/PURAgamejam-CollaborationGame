using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn_Controller : MonoBehaviour
{
    Animator anim;

    void onAnimationStart()
    {
        anim.SetTrigger("FadeIn");
    }
}
