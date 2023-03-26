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
}
