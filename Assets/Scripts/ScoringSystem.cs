using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public GameObject scoreTextAlt;
    public static int theScore;

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score: " + theScore;
        scoreTextAlt.GetComponent<Text>().text = "Score: " + theScore;
    }
}
