using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseColor : MonoBehaviour
{
    Color currentColor;
    Color Blue = new Color(0.192f, 0.494f, 0.8f, 1f);
    Color Red = new Color(0.773f, 0.149f, 0.235f, 1f);
    Color Yellow = new Color(0.937f, 0.816f, 0.388f, 1f);
    Color Purple = new Color(0.482f, 0.271f, 0.671f, 1f);
    Color Orange = new Color(0.89f, 0.506f, 0.392f, 1f);
    Color Green = new Color(0.286f, 0.698f, 0.49f, 1f);

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
        if (color == Red)
        {
            return Green;
        }
        else if (color == Green)
        {
            return Red;
        }
        else if (color == Blue)
        {
            return Orange;
        }
        else if (color == Orange)
        {
            return Blue;
        }
        else if (color == Purple)
        {
            return Yellow;
        }
        else if (color == Yellow)
        {
            return Purple;
        }
        else
        {
            return color;
        }
    }
}
