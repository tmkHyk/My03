using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour {

    //ゴールしたかどうか　trueの時ゴールした
    public bool isGoal = false;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
    }

    /// <summary>
    /// 衝突判定
    /// </summary>
    /// <param name="other"></param>
    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        isGoal = true;
    //        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //    }
    //}
}
