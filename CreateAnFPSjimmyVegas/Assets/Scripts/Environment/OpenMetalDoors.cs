using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMetalDoors : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject leftDoor;
    public GameObject rightDoor;

    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 3)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);

            if(Input.GetButtonDown("Action"))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                leftDoor.GetComponent<Animator>().Play("LeftSlide");
                rightDoor.GetComponent<Animator>().Play("RightSlide");
            }
        }
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}
