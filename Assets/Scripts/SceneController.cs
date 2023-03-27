using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]GameObject tutorial;

    public void GameStart()
    {
        SceneManager.LoadScene("Main1");
    }

    public void Tutorial()
    {
        tutorial.SetActive(true);
    }

    public void TutorialExit()
    {
        tutorial.SetActive(false);
    }

    public void Reload1()
    {
        SceneManager.LoadScene("Main1");
    }

    public void Reload2()
    {
        SceneManager.LoadScene("Main2");
    }

    public void Reload3()
    {
        SceneManager.LoadScene("Main3");
    }
}
