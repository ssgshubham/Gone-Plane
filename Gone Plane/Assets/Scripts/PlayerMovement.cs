using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movespeed;
    [SerializeField] float rotatespeed;

    public AudioClip audClip;
    public AudioSource Auds;
    
     


    bool GameOver = false;

    Rigidbody2D rb;

    Camera cam;



    

   


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
        
    }

   

    void Update()
    {
        

        if (!GameOver)
        {
                   


            if (Input.GetKey(KeyCode.RightArrow))
            {
                right();
                
            }
            else if(Input.GetKey(KeyCode.LeftArrow))
            {
                left();
            }
        }
    }

    public void right()
    {
        
            transform.Rotate(Vector3.forward * (-rotatespeed) * Time.deltaTime);
            Debug.Log("rr");
        
        
    }

    public void left()
    {
        Debug.Log("rr");
        transform.Rotate(Vector3.forward * (rotatespeed) * Time.deltaTime);
    }

    void FixedUpdate()
    {
        if (!GameOver)
        {
            rb.AddRelativeForce(new Vector3(movespeed * Time.fixedDeltaTime, 0f, 0f));
            cam.transform.position = new Vector3(transform.position.x, transform.position.y, cam.transform.position.z);


        }
    }

    void LaterUpdate()
    {
        if (!GameOver)
        {
           cam.transform.position = new Vector3 (transform.position.x, transform.position.y, cam.transform.position.z);
        }
    }

    void OnCollisionEnter2D()
    {
        if (!GameOver)
        {
            GameOver = true;
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<PolygonCollider2D>().enabled = false;
            GetComponentInChildren<ParticleSystem>().Play();
            Auds.PlayOneShot(audClip);
            Invoke("restart", 2f);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(0);
    }
}
