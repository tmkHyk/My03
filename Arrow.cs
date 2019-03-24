using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

    //HierarchyからGoalオブジェクトを格納する
    GameObject goal;

	// Use this for initialization
	void Start () {
        //HierarchyからGoalオブジェクトを探す
        goal = GameObject.Find("Goal");
	}
	
	// Update is called once per frame
	void Update () {

        //回転しない
        Quaternion.LookRotation(goal.transform.position);
	}
}
