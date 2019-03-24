using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    //テキスト
    Text t, t2, t3;
    //時間制限　タイマー
    float timer = 60;

    public static int score = 0;

    // Use this for initialization
    void Start()
    {
        //HierarchyからScoreTextテキストを発見、格納
        t = GameObject.Find("ScoreText").GetComponent<Text>();
        //HierarchyからTimerTextテキストを発見、格納
        t2 = GameObject.Find("TimerText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //タイマーが0以下になったら
        if (timer <= 0)
        {
            //タイマーを0に指定
            timer = 0;
            //Resultシーンへ
            SceneManager.LoadScene("Result");
        }
        else  //まだタイマーが0以上のとき
        {
            //毎秒１ずつ減少
            timer -= Time.deltaTime;
        }

        //ScoreTextにスコアを表示
        t.text = "Score : " + (score).ToString();
        //TimerTextにタイマーを表示
        t2.text = "Timer : " + (timer).ToString("f1");
    }
}
