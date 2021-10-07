using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Vuforia;


public class ImageDistance : MonoBehaviour
{
    public GameObject trackedImageFollower1;
    public GameObject trackedImageFollower2;
    public GameObject cactus1;
    public GameObject cactus2;
    public float distance = 1000f;
    public void Start()
    {
        cactus1.GetComponent<Animation>().Play("Idle");
        cactus2.GetComponent<Animation>().Play("Idle");
    }
    public void Update()
    {
        Vector3 firstImage = trackedImageFollower1.transform.position;
        Vector3 secondImage = trackedImageFollower2.transform.position;

        float dist = Vector3.Distance(firstImage, secondImage);
        if (dist < this.distance)
        {
            cactus1.GetComponent<Animation>().Play("Walk");
            cactus2.GetComponent<Animation>().Play("Walk");
        }
        else
        {
            cactus1.GetComponent<Animation>().Play("Idle");
            cactus2.GetComponent<Animation>().Play("Idle");
        }

        Debug.Log(cactus1.GetComponent<Animation>());

    }
}