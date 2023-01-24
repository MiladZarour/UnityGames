using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControl : MonoBehaviour
{
    public static int dealtCardNumber;
    public static int newCardNumber;
    public GameObject correctText;
    public GameObject incorrectText;
    public static bool guessHi = false;
    public static bool guessLo = false;
    public GameObject hiButton;
    public GameObject loButton;
    public GameObject dealButton;

    // equal number = winner
    void Update()
    {
        if (guessHi == true)
        {
            guessHi = false;
            hiButton.SetActive(false);
            loButton.SetActive(false);
            StartCoroutine(GuessingHigher());
        }
        if (guessLo == true)
        {
            guessLo = false;
            hiButton.SetActive(false);
            loButton.SetActive(false);
            StartCoroutine(GuessingLower());
        }
    }

    IEnumerator GuessingHigher()
    {
        yield return new WaitForSeconds(1);
        if(newCardNumber >= dealtCardNumber)
        {
            correctText.SetActive(true);
        }
        else
        {
            incorrectText.SetActive(true);
        }
    }
    IEnumerator GuessingLower()
    {
        yield return new WaitForSeconds(1);
        if (newCardNumber <= dealtCardNumber)
        {
            correctText.SetActive(true);
        }
        else
        {
            incorrectText.SetActive(true);
        }
    }
}
