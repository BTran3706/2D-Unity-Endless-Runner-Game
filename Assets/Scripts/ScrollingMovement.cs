using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingMovement : MonoBehaviour
{

    private float speed = 5;
    public float maxScroll;

    void Update()
    {
        if (transform.position.x <= maxScroll)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }

}