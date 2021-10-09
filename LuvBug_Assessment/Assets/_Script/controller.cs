using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class controller : MonoBehaviour
{
    public Vector3 Min;
    public Vector3 Max;
    public Vector3 random;
    public float yAxis;

    public GameObject FishGood;
    public GameObject FishBad;

    public bool goodspawn = true;
    public bool badspawn = true;

    public GameObject player;

    public int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        range();
    }

    // Update is called once per frame
    void Update()
    {
        yAxis = UnityEngine.Random.Range(Min.y, Max.y);

        random = new Vector3(6, yAxis,0);

        Spawn();
        Score();
    }
    public void range()
    {
        Min = new Vector3(6, 2, 0);
        Max = new Vector3(6, -5, 0);
    }
    public void Spawn()
       
    { 
        if(goodspawn == true)
        {
            Instantiate(FishGood, random, Quaternion.Euler (0F,0F,90F));
            goodspawn = false;
        }
        if (badspawn == true)
        {
            Instantiate(FishBad, random, Quaternion.Euler(0F, 0F, 90F));
            badspawn = false;
        }
    }
    public void Score()
    {
        score = player.GetComponent<player>().score;
        scoreText.text = score.ToString();
        


    }
}
