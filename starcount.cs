using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starcount : MonoBehaviour
{
    public GameObject StarScore;
    public int theScore;

    void OnTriggerEnter(Collider other)
    {
        theScore += 1;
        StarScore.GetComponent<Text>().text = "Stars: " + theScore;
    }
}
