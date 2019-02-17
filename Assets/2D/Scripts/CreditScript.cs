using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditScript : MonoBehaviour
{

    public GameObject creditsMenuUI;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Time.timeScale = 0f;
            creditsMenuUI.SetActive(true);
            
        }
    }
}
