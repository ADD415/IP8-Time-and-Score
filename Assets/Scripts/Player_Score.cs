using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{
    private float time = 0;
    public int playerScore = 0;
    public GameObject timeUI;
    public GameObject playerScoreUI;

    void Update()
    {
        time += Time.deltaTime;
        timeUI.gameObject.GetComponent<Text>().text = ("Time: " + (int)time);
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
    }

    void OnTriggerEnter2D (Collider2D trig)
    {

        if (trig.gameObject.name == "Object")
        {
            playerScore += 10;
            Destroy(trig.gameObject);
        }
    }
}  
