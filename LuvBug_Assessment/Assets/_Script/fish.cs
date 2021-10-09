using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : MonoBehaviour
{
    public GameObject fishObj;
    public GameObject controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("gameController");
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        fishObj.transform.Translate(Vector2.up * 2.5f * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Left")
        {
            if (gameObject.tag == "Good")
                controller.GetComponent<controller>().goodspawn = true;
            if (gameObject.tag == "Bad")
                controller.GetComponent<controller>().badspawn = true;
            Collider.Destroy(this.gameObject);
        }
    }

}
