using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameObject shel;
    public Color shelColor;
    public Color playerColor;

    Color Blue = new Color(0.192f, 0.494f, 0.8f, 1f);
    Color Red = new Color(0.773f, 0.149f, 0.235f, 1f);
    Color Yellow = new Color(0.937f, 0.816f, 0.388f, 1f);
    Color Purple = new Color(0.482f, 0.271f, 0.671f, 1f);
    Color Orange = new Color(0.89f, 0.506f, 0.392f, 1f);
    Color Green = new Color(0.286f, 0.698f, 0.49f, 1f);
    Color White = new Color(1f,1f,1f);

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ColorCahange");
        shel = other.gameObject;
        shelColor = shel.GetComponent<Renderer>().material.color;
        playerColor = GetComponent<Renderer>().material.color;

        if(playerColor == White)
        {
            playerColor = shelColor;
        }

        //青+赤＝紫・青＋黄色＝緑
        if(playerColor == Blue)
        {
            if(shelColor == Red)
            {
                playerColor = Purple;
            }
            if(shelColor == Yellow)
            {
                playerColor = Green;
            }
        }
        //赤＋青＝紫・赤＋黄色＝オレンジ
        if(playerColor == Red)
        {
            if(shelColor == Blue)
            {
                playerColor = Purple;
            }
            if(shelColor == Yellow)
            {
                playerColor = Orange;
            }
        }
        
        //黄＋青＝緑・黄色＋赤＝オレンジ
        if(playerColor == Yellow)
        {
            if(shelColor == Blue)
            {
                playerColor = Green;
            }
            if(shelColor == Red)
            {
                playerColor = Orange;
            }
        }

        GetComponent<Renderer>().material.color = playerColor;

        shel.SetActive(false);
    }
}
