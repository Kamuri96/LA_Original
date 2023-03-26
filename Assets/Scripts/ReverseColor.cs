using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseColor : MonoBehaviour
{
    Color currentColor;
    Color blue = new Color(0.192f, 0.494f, 0.8f, 1f);
    Color red = new Color(0.773f, 0.149f, 0.235f, 1f);
    Color yellow = new Color(0.937f, 0.816f, 0.388f, 1f);
    Color purple = new Color(0.482f, 0.271f, 0.671f, 1f);
    Color orange = new Color(0.89f, 0.506f, 0.392f, 1f);
    Color green = new Color(0.286f, 0.698f, 0.49f, 1f);
    Color white = new Color(1f, 1f, 1f);
    Color black = new Color(0f, 0f, 0f);

    void Start()
    {
        currentColor = GetComponent<Renderer>().material.color;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentColor = ComplementaryColor(currentColor);
        }
        GetComponent<Renderer>().material.color = currentColor;
    }

    //補色にする関数
    Color ComplementaryColor(Color color)
    {
        if (color == red)
        {
            return green;
        }
        else if (color == green)
        {
            return red;
        }
        else if (color == blue)
        {
            return orange;
        }
        else if (color == orange)
        {
            return blue;
        }
        else if (color == purple)
        {
            return yellow;
        }
        else if (color == yellow)
        {
            return purple;
        }
        else if (color == white)
        {
            return black;
        }
        else if (color == black)
        {
            return white;
        }
        else
        {
            return color;
        }
    }
}
