using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o�[��\������e�L�X�g
    private GameObject gameoverText;

    //���_��\������e�L�X�g
    private GameObject tokutenText;

    //���_
    public int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        //�V�[���̒���GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");

        //��ɕ킢�V�[����TokutenText�I�u�W�F�N�g�擾
        this.tokutenText = GameObject.Find("TokutenText");

        //TokutenText��score��\��
        this.tokutenText.GetComponent<Text>().text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if(this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o�[��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        //TokutenText��score��\��
        this.tokutenText.GetComponent<Text>().text = score.ToString();
    }

    //�Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;;
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
