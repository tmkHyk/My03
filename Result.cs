using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour {

    //テキスト
    Text text;
    public int score;

	// Use this for initialization
	void Start () {

        score = Score.score;
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        //スコアの表示
        text.text = "HighScore : " + score.ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Title");
        }
	}
}
