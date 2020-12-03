using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarrotText : MonoBehaviour
{

    private Text carrots; 
    public static int numCarrots = 0;
    public int totalNumCarrots;

    void Start()
    {
        carrots = GetComponent<Text>();
    }

    void Update()
    {
        carrots.text = numCarrots + " out of " + totalNumCarrots + " Carrots";
    }

}
