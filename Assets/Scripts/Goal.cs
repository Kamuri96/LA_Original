using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "key")
        {
            if(SceneManager.GetActiveScene().name == "Main1")
            {
                SceneManager.LoadScene("Main2");
            }
            if (SceneManager.GetActiveScene().name == "Main2")
            {
                SceneManager.LoadScene("Main3");
            }
        }

        if (other.gameObject.tag == "goal")
        {
            SceneManager.LoadScene("Clear");
        }
    }
}
