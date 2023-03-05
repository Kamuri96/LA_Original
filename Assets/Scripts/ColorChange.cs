using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameObject shel;
    public Color shelColor;
    public Color playerColor;

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        shel = other.gameObject;
        shelColor = shel.GetComponent<Renderer>().material.color;
        playerColor = GetComponent<Renderer>().material.color;

        GetComponent<Renderer>().material.color = shelColor;

        //青＋赤→紫
        if(playerColor == new Color(0.192f, 0.494f, 0.8f, 1f) && shelColor == new Color(0.773f,0.149f,0.235f,1f))
        {
            GetComponent<Renderer>().material.color = new Color(0.482f, 0.271f, 0.671f, 1f);
        }
        //赤＋青→紫
        if (playerColor == new Color(0.773f, 0.149f, 0.235f, 1f) && shelColor == new Color(0.192f, 0.494f, 0.8f, 1f))
        {
            GetComponent<Renderer>().material.color = new Color(0.482f, 0.271f, 0.671f, 1f);
        }
        //青＋黄→緑
        if (playerColor == new Color(0.192f, 0.494f, 0.8f, 1f) && shelColor == new Color(0.937f, 0.816f, 0.388f, 1f))
        {
            GetComponent<Renderer>().material.color = new Color(0.286f, 0.698f, 0.49f, 1f);
        }
        //黄＋青→緑
        if (playerColor == new Color(0.937f, 0.816f, 0.388f, 1f) && shelColor == new Color(0.192f, 0.494f, 0.8f, 1f))
        {
            GetComponent<Renderer>().material.color = new Color(0.286f, 0.698f, 0.49f, 1f);
        }
        //赤＋黄→オレンジ
        if (playerColor == new Color(0.773f, 0.149f, 0.235f, 1f) && shelColor == new Color(0.937f, 0.816f, 0.388f, 1f))
        {
            GetComponent<Renderer>().material.color = new Color(0.89f, 0.506f, 0.392f, 1f);
        }
        //黄＋赤→オレンジ
        if (playerColor == new Color(0.937f, 0.816f, 0.388f, 1f) && shelColor == new Color(0.773f, 0.149f, 0.235f, 1f))
        {
            GetComponent<Renderer>().material.color = new Color(0.89f, 0.506f, 0.392f, 1f);
        }

        shel.SetActive(false);
    }
}
