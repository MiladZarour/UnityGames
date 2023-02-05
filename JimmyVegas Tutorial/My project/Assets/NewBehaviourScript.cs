using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public int subscribeToMe;
    public float clickthebell = 1.234f;
    public GameObject thisObject;


    // Start is called before the first frame update
    void Start()
    {
        thisObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        subscribeToMe += 1;
    }
}
