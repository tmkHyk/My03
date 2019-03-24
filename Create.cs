using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //Targetオブジェクトの初期生成位置をランダムで指定
        transform.position = new Vector3(Random.Range(-4,0), 0, Random.Range(0, 30));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
