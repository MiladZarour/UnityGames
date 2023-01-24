using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealCard : MonoBehaviour
{
    public GameObject dealtCard;
    public void DealMyNewCard()
    {
        dealtCard.SetActive(true);
    }
}
