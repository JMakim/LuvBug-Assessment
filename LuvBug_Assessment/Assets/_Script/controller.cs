using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public Vector3 Min;
    public Vector3 Max;

    public Vector3 random;

    public GameObject spawner;

    public GameObject FishGood;
    public GameObject FishBad;

    public bool goodspawn = true;
    public bool badspawn = true;

    public float yAxis;
    // Start is called before the first frame update
    void Start()
    {
        range();
    }

    // Update is called once per frame
    void Update()
    {
        yAxis = UnityEngine.Random.Range(Min.y, Max.y);

        random = new Vector3(6, yAxis,0);

        Spawn();
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
}
