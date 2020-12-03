using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private float speed = 5;
    private float jumpForce = 1350;
    private double outOfScreenY = -5.5;
    public double endOfLevelX;
    private float jumpHeight;

    public AudioSource sound;
    private bool grounded = true; 
    public GameObject camera;

    void Update()
    {

        transform.position += Vector3.right * Time.deltaTime * speed;
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);
            sound.Play();
            grounded = false;
        }
        if (transform.position.x >= endOfLevelX)
        {
            CarrotText.numCarrots = 0;
            SceneManager.LoadScene("LevelCompleted");
        }
        if (transform.position.y <= outOfScreenY || transform.position.x < camera.transform.position.x - 10)
        {
            CarrotText.numCarrots = 0;
            SceneManager.LoadScene("DeadScreen");
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Red" || other.gameObject.tag == "Green" || other.gameObject.tag == "Blue")
        {
            grounded = true;
        }
    }



}
