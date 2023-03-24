using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "key")
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

        if (other.gameObject.name == "goal")
        {
            SceneManager.LoadScene("Clear");
        }
    }
}
