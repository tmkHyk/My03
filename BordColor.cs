using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BordColor : MonoBehaviour {

    [SerializeField,Tooltip("的にアタッチするマテリアル　0:青　1:赤")]
    Material[] mat;

    //2つにする意味？
    //Bordオブジェクトの子オブジェクトのCubeを格納
    GameObject[] bords;
    //Bordタグのオブジェクトを格納
    public List<GameObject> list;

    //ゴールできるかどうか(ゴールが表示されているかどうか)　trueの時ゴールできる
    public static bool isClear = false;  //TargetDestroyクラスで使用

    // Use this for initialization
    void Start()
    {
        //HierarchyからBordタグのオブジェクトを発見、格納
        bords = GameObject.FindGameObjectsWithTag("Bord");

        //配列bordsからひとつずつマテリアルを指定する
        foreach (GameObject bord in bords)
        {
            //0,1間でランダム生成
            int r = Random.Range(0, 2);

            //マテリアルの指定
            switch (r)
            {
                //rが0のとき赤いマテリアル
                case 0:
                    bord.GetComponent<Renderer>().material = mat[1];
                    break;
                //rが0のとき青いマテリアル
                case 1:
                    bord.GetComponent<Renderer>().material = mat[0];
                    break; ;

            }
        }
    }

    // Update is called once per frame
    void Update() {

        //HierarchyからBordタグのオブジェクトを発見、格納
        list = new List<GameObject>(GameObject.FindGameObjectsWithTag("Bord"));

        //リストの各
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == null)
            {
                list.RemoveAt(i);
            }
        }

        //リストが空になったら(Bordオブジェクトがなくなったら)isClearをtrueに
        if (list.Count == 0)
        {
            isClear = true;
        }
    }
}
