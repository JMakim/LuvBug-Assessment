using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public GameObject shark;


    public float curHP = 3;
    public int score;

    public Text HPtext;

    Rigidbody rb;



    public GameObject controller;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GameObject.Find("gameController");
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        HPtext.text = curHP.ToString();
    }

    public void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.left * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * 5 * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Good")
        {
            controller.GetComponent<controller>().goodspawn = true;
            score++;
            Collider.Destroy(collision.gameObject);
        }

        if (collision.collider.tag == "Bad")
        {
            controller.GetComponent<controller>().badspawn = true;
            curHP--;
            Collider.Destroy(collision.gameObject);
        }
    }
}
