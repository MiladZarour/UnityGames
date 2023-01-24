﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealCard : MonoBehaviour
{
    public GameObject[] dealtCard;
    public int cardGenerate;
    public GameObject hiButton;
    public GameObject loButton;
    public GameObject dealButton;
    public void DealMyNewCard()
    {
        cardGenerate = Random.Range(2, 15);
        dealtCard[cardGenerate].SetActive(true);
        hiButton.SetActive(true);
        loButton.SetActive(true);
        dealButton.SetActive(false);
    }
}
