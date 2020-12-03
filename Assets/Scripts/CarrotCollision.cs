using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarrotCollision : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.CompareTag("Player"))
        {
            Destroy(gameObject);
            CarrotText.numCarrots++;
        }
    }

}
