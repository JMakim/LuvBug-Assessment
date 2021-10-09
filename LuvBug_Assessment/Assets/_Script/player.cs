using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject shark;

    public GameObject healthBar;

    public int curHP = 3;

    Rigidbody rb;

    GameObject controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("gameController");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
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
            Collider.Destroy(collision.gameObject);
        }

        if (collision.collider.tag == "Bad")
        {
            Collider.Destroy(collision.gameObject);
        }
    }
}
