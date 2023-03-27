using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButton : MonoBehaviour
{
    public void HintOpen()
    {
        gameObject.SetActive(true);
    }

    public void HintClose()
    {
        gameObject.SetActive(false);
    }
}
