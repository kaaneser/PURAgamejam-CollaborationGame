using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator levelAnim;

    public void PlayFade()
    {
        levelAnim.SetTrigger("FadeOut");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void playAnim()
    {
        levelAnim.SetTrigger("FadeIn");
    }
    
    public void Quit()
    {
        Application.Quit();
    }

}
