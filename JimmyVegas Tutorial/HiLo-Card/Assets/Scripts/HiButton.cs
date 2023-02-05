using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiButton : MonoBehaviour
{
    public GameObject[] dealtCard;
    public int cardGenerate;
    public void DealHiCard()
    {
        cardGenerate = Random.Range(2, 15);
        dealtCard[cardGenerate].SetActive(true);
        CardControl.newCardNumber = cardGenerate;
        CardControl.guessHi = true;
    }
}
