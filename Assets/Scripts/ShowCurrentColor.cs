using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCurrentColor : MonoBehaviour
{
    public GameObject[] colors;
    private int index;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            colors[index].SetActive(false);
            index++;
            if (index > 2)
            {
                index = 0;
            }
            colors[index].SetActive(true);
        }
    }

}