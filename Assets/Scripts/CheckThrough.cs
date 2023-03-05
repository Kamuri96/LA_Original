using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckThrough : MonoBehaviour
{
    public GameObject seawood;
    public Color seawoodColor;
    public Color playerColor;
    public BoxCollider seawoodCollider;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        seawood = collision.gameObject;
        seawoodColor = seawood.GetComponent<Renderer>().material.color;
        playerColor = GetComponent<Renderer>().material.color;

        if(playerColor == seawoodColor)
        {
            seawoodCollider = collision.gameObject.GetComponent<BoxCollider>();
            seawoodCollider.enabled = false;
        }
    }
}
