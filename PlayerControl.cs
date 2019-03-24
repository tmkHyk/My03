using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{

    [SerializeField, Range(0, 2000), Tooltip("弾の速度")]
    private float speed;

    //Bullet(弾)オブジェクトをアタッチ
    public GameObject bullet;
    //Bulletの発射位置MuzzleをHierarchyからMuzzleオブジェクトでアタッチ
    public GameObject muzzle;

    public GameObject target;
    MeshCollider road;

    // Use this for initialization
    void Start()
    {
        //初期位置
        transform.position = new Vector3(0, 5, -10);

        road = GameObject.Find("Road").GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //Bボタンまたはマウス左クリックで発砲
        if (Input.GetKeyDown(KeyCode.B) || Input.GetMouseButtonDown(0))
        {
            //発砲処理
            Shoot();
        }

        //現在のy座標が-5より下になったら
        if (road.enabled == true && transform.position.y < -5)
        {
            //初期位置に戻る
            Start();
        }
        if(road.enabled == false && transform.position.y < -20)
        {
            Instantiate(target);
            road.enabled = true;
            Start();
        }
    }

    //発砲処理
    void Shoot()
    {
        //新しいゲームオブジェクトbulletsを宣言 bulletオブジェクトを複製して生成
        GameObject bullets = Instantiate(bullet);
        //新規ベクトルforceを生成　進行方向にspeed×10した値を代入
        Vector3 force = Camera.main.transform.forward * speed * 10;
        //bulletsにRigidbodyを追加
        bullets.GetComponent<Rigidbody>().AddForce(force);
        //bulletsのpositionを発射位置muzzleの位置に指定
        bullets.transform.position = muzzle.transform.position;
        //発砲(生成)して1秒後に削除
        Destroy(bullets, 1.0f);
    }

    /// <summary>
    /// 衝突判定
    /// </summary>
    /// <param name="other"></param>
    void OnCollisionEnter(Collision other)
    {
        //何か他のオブジェクトに衝突したらbulletを削除
        //if (other.gameObject)
        //{
        //    Destroy(bullet);
        //}
        //Playerがゴールしたら(ゴールに衝突したら)
        if (other.gameObject.name == "Goal")
        {
            //Mainシーンを再ロード(最初から)
            SceneManager.LoadScene("Main");
        }
    }
}