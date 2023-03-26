using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameObject shel;
    public Color shelColor;
    public Color playerColor;

    Color blue = new Color(0.192f, 0.494f, 0.8f, 1f);
    Color red = new Color(0.773f, 0.149f, 0.235f, 1f);
    Color yellow = new Color(0.937f, 0.816f, 0.388f, 1f);
    Color purple = new Color(0.482f, 0.271f, 0.671f, 1f);
    Color orange = new Color(0.89f, 0.506f, 0.392f, 1f);
    Color green = new Color(0.286f, 0.698f, 0.49f, 1f);
    Color white = new Color(1f, 1f, 1f);
    Color black = new Color(0f, 0f, 0f);

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ColorCahange");
        shel = other.gameObject;
        shelColor = shel.GetComponent<Renderer>().material.color;
        playerColor = GetComponent<Renderer>().material.color;

        if(playerColor == white)
        {
            playerColor = shelColor;
        }

        //青+赤＝紫・青＋黄色＝緑
        else if(playerColor == blue)
        {
            if(shelColor == red)
            {
                playerColor = purple;
            }
            if(shelColor == yellow)
            {
                playerColor = green;
            }
        }
        //赤＋青＝紫・赤＋黄色＝オレンジ
        else if(playerColor == red)
        {
            if(shelColor == blue)
            {
                playerColor = purple;
            }
            if(shelColor == yellow)
            {
                playerColor = orange;
            }
        }
        
        //黄＋青＝緑・黄色＋赤＝オレンジ
        else if(playerColor == yellow)
        {
            if(shelColor == blue)
            {
                playerColor = green;
            }
            if(shelColor == red)
            {
                playerColor = orange;
            }
        }

        //3色混ざると黒
        else if(playerColor == purple || playerColor == green || playerColor == orange)
        {
                playerColor = black;
        }
        
        GetComponent<Renderer>().material.color = playerColor;

        shel.SetActive(false);
    }
}
