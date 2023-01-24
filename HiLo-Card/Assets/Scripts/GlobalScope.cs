using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScope : MonoBehaviour
{
    
    public static int currentScore;
    public GameObject scoreDisplay;

    void Update()
    {
        scoreDisplay.GetComponent<Text>().text = "STREAK: " + currentScore;
    }
}
