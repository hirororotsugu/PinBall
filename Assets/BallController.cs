using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバーを表示するテキスト
    private GameObject gameoverText;

    //得点を表示するテキスト
    private GameObject tokutenText;

    //得点
    public int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        //シーンの中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        //上に倣いシーンのTokutenTextオブジェクト取得
        this.tokutenText = GameObject.Find("TokutenText");

        //TokutenTextにscoreを表示
        this.tokutenText.GetComponent<Text>().text = "SCORE:" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if(this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバーを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        //TokutenTextにscoreを表示
        this.tokutenText.GetComponent<Text>().text = "SCORE:" + score.ToString();
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.score += 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            this.score += 30;
        }
    }
}
