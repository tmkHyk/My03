using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BordCreate : MonoBehaviour {

    public GameObject bord;
    GameObject fram;

	// Use this for initialization
	void Start () {

        //使用していない
        fram = GameObject.Find("Fram");

        Instantiate(bord, new Vector3(fram.transform.position.x + 0.65f, 2.85f, fram.transform.position.z),Quaternion.identity);
        Instantiate(bord, new Vector3(fram.transform.position.x + 0.65f, 1.75f, fram.transform.position.z), Quaternion.identity);
        Instantiate(bord, new Vector3(fram.transform.position.x + 0.65f, 0.65f, fram.transform.position.z), Quaternion.identity);
        Instantiate(bord, new Vector3(fram.transform.position.x + 1.75f, 2.85f, fram.transform.position.z), Quaternion.identity);
        Instantiate(bord, new Vector3(fram.transform.position.x + 1.75f, 1.75f, fram.transform.position.z), Quaternion.identity);
        Instantiate(bord, new Vector3(fram.transform.position.x + 1.75f, 0.65f, fram.transform.position.z), Quaternion.identity);
        Instantiate(bord, new Vector3(fram.transform.position.x + 2.85f, 2.85f, fram.transform.position.z), Quaternion.identity);
        Instantiate(bord, new Vector3(fram.transform.position.x + 2.85f, 1.75f, fram.transform.position.z), Quaternion.identity);
        Instantiate(bord, new Vector3(fram.transform.position.x + 2.85f, 0.65f, fram.transform.position.z), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
