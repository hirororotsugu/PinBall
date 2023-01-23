using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoint;

    //初期の傾き
    private float defaultAngle = 20;
    //はじいた時の傾き
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {
        //HingeJointコンポーネント取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);

        Debug.Log(Screen.width);
    }

    // Update is called once per frame
    void Update()
    {
        //左矢印キー、Ａキーを押したとき左フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //右矢印キー、Ｄキーを押したとき右フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //下矢印キー、Ｓキーを押したとき両フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.DownArrow) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.S) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.S) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //矢印キー、Ａ、Ｓ、Ｄキーが離されたときフリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.LeftArrow)&& tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.DownArrow) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.S) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)&& tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.DownArrow) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.S) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        //Vector2のインスタンス生成0
        Vector2 vec0 = new Vector2(0f, 0f);
        //Vector2のインスタンス生成1
        Vector2 vec1 = new Vector2(0f, 0f);

        //画面がタップされたとき
        if (Input.touchCount > 0)
        {
            // タッチ情報の取得0
            Touch touch0 = Input.GetTouch(0);

            //押した瞬間の処理0
            if (touch0.phase == TouchPhase.Began)
            {
                Debug.Log("押した瞬間1本");
                Vector2 pos0 = touch0.position;
                vec0 = pos0;

                // vecのX座標が0以上の場合タップで右フリッパー動く
                if (vec0.x >= 540 && tag == "RightFripperTag")
                {
                    SetAngle(this.flickAngle);
                }

                // vecのX座標が0以下の場合タップで左フリッパー動く
                if (vec0.x <= 540 && tag == "LeftFripperTag")
                {
                    SetAngle(this.flickAngle);
                }
            }

            //離した瞬間の処理0
            if (touch0.phase == TouchPhase.Ended)
            {
                Debug.Log("離した瞬間1本");
                Vector2 pos0 = touch0.position;
                vec0 = pos0;

                // vecのX座標が0以上の場合離すで右フリッパー戻る
                if (vec0.x >= 540 && tag == "RightFripperTag")
                {
                    SetAngle(this.defaultAngle);
                }

                // vecのX座標が0以下の場合離すで左フリッパー戻る
                if (vec0.x <= 540 && tag == "LeftFripperTag")
                {
                    SetAngle(this.defaultAngle);
                }
            }


            if (Input.touchCount > 1)
            {

                // タッチ情報の取得1
                Touch touch1 = Input.GetTouch(1);

                
                //押した瞬間の処理1
                if (touch1.phase == TouchPhase.Began)
                {
                    Debug.Log("押した瞬間2本");
                    Vector2 pos1 = touch1.position;
                    vec1 = pos1;

                    // vecのX座標が0以上の場合タップで右フリッパー動く
                    if (vec1.x >= 540 && tag == "RightFripperTag")
                    {
                        SetAngle(this.flickAngle);
                    }

                    // vecのX座標が0以下の場合タップで左フリッパー動く
                    if (vec1.x <= 540 && tag == "LeftFripperTag")
                    {
                        SetAngle(this.flickAngle);
                    }
                }
                //離した瞬間の処理1
                if (touch1.phase == TouchPhase.Ended)
                {
                    Debug.Log("離した瞬間2本");
                    Vector2 pos1 = touch1.position;
                    vec1 = pos1;

                    // vecのX座標が0以上の場合離すで右フリッパー戻る
                    if (vec1.x >= 540 && tag == "RightFripperTag")
                    {
                        SetAngle(this.defaultAngle);
                    }

                    // vecのX座標が0以下の場合離すで左フリッパー戻る
                    if (vec1.x <= 540 && tag == "LeftFripperTag")
                    {
                        SetAngle(this.defaultAngle);
                    }
                }
            }
        }
     }

    //フリッパーの傾きを設定
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}
