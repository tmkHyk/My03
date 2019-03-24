using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static float highScore;
    Text text;

    // Use this for initialization
    void Start()
    {
        highScore = highScore < Score.score ? Score.score : highScore;
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        text.text = "HighScore : " + highScore.ToString();
    }
}
