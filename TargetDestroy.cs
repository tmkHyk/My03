using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDestroy : MonoBehaviour
{
    //Bordタグのオブジェクトを格納
    //GameObject[] bords;
    public List<GameObject> bords;

    public MeshCollider road;

    // Use this for initialization
    void Start()
    {
        //HierarchyからBordタグのオブジェクトを発見、格納
        //bords = GameObject.FindGameObjectsWithTag("Bord");
        foreach (GameObject bord in GameObject.FindGameObjectsWithTag("Bord"))
        {
            bords.Add(bord);
        }

        road = GameObject.Find("Road").GetComponent<MeshCollider>();
        road.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject bord in bords)
        {
            if (bord.GetComponent<BordDestroy>().mat.Contains("2") || bord.GetComponent<BordDestroy>().isActive == false)
            {
                bords.Remove(bord);
            }
        }

        if (bords.Count == 0)
        {
            road.enabled = false;
            Destroy(this.gameObject);
        }
    }
}