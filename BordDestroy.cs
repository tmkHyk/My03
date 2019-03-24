using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BordDestroy : MonoBehaviour
{
    [SerializeField, Range(0, 20), Tooltip("ボードオブジェクトの加点ポイント")]
    int point = 12;
    public string mat;

    public bool isActive = true;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        mat = this.gameObject.GetComponent<Renderer>().material.name;
    }

    /// <summary>
    /// 衝突判定
    /// </summary>
    /// <param name="other"></param>
    void OnCollisionEnter(Collision other)
    {
        //弾(Bulletオブジェクト)と衝突したとき
        if (other.gameObject.tag == "Bullet")
        {
            if (!mat.Contains("2"))
            {
                point = point <= 0 ? 0 : point - 2;
            }
            else
            {
                point = -5;
            }
        }
    }

    /// <summary>
    /// 衝突範囲から抜け出た
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerExit(Collider other)
    {
        //Wallタグのオブジェクトから離れた時
        if (other.gameObject.name == "Wall")
        {
            Score.score += point;
            isActive = false;
            //2秒後に削除
            Destroy(this.gameObject, 2.0f);
        }
    }
}
