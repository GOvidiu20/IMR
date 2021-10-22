using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTrigger : MonoBehaviour
{
    public GameObject hand;

    void Start()
    {
        hand.GetComponent<Animator>().Play("Armature|Idle");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Grab"))
        {
            hand.GetComponent<Animator>().Play("Armature|GrabObject");
        }
        if (Input.GetButtonDown("Throw"))
        {
            hand.GetComponent<Animator>().Play("Armature|TriggerHand");
        }
    }
}
