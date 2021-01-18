using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeController : MonoBehaviour
{
    public LevelChanger levelChanger;

    public void onAnimationEnd()
    {
        levelChanger.PlayGame();
    }
}
