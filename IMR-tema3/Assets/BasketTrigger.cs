using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketTrigger : MonoBehaviour
{
    public GameObject ball;
    public GameObject cube;
    public GameObject wall;
    public float timeRemaining;
    // Start is called before the first frame update
    void Start()
    {
        wall.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(ball.transform.position, cube.transform.position) <= 0.5) 
        {
            wall.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            timeRemaining = 2;

        }
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            wall.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
    }
}
