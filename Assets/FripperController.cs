using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJoint�R���|�[�l���g������
    private HingeJoint myHingeJoint;

    //�����̌X��
    private float defaultAngle = 20;
    //�͂��������̌X��
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {
        //HingeJoint�R���|�[�l���g�擾
        this.myHingeJoint = GetComponent<HingeJoint>();

        //�t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultAngle);

        Debug.Log(Screen.width);
    }

    // Update is called once per frame
    void Update()
    {
        //�����L�[�A�`�L�[���������Ƃ����t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //�E���L�[�A�c�L�[���������Ƃ��E�t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //�����L�[�A�r�L�[���������Ƃ����t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.DownArrow) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.S) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.S) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //���L�[�A�`�A�r�A�c�L�[�������ꂽ�Ƃ��t���b�p�[�����ɖ߂�
        if (Input.GetKeyUp(KeyCode.LeftArrow)&& tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.DownArrow) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.S) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)&& tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.DownArrow) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.S) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        //Vector2�̃C���X�^���X����0
        Vector2 vec0 = new Vector2(0f, 0f);
        //Vector2�̃C���X�^���X����1
        Vector2 vec1 = new Vector2(0f, 0f);

        //��ʂ��^�b�v���ꂽ�Ƃ�
        if (Input.touchCount > 1)
        {
            // �^�b�`���̎擾0
            Touch touch0 = Input.GetTouch(0);

            //�������u�Ԃ̏���0
            if (touch0.phase == TouchPhase.Began)
            {
                Debug.Log("�������u��1�{");
                Vector2 pos0 = touch0.position;
                vec0 = pos0;

                // vec��X���W��0�ȏ�̏ꍇ�^�b�v�ŉE�t���b�p�[����
                if (vec0.x >= 540 && tag == "RightFripperTag")
                {
                    SetAngle(this.flickAngle);
                }

                // vec��X���W��0�ȉ��̏ꍇ�^�b�v�ō��t���b�p�[����
                if (vec0.x <= 540 && tag == "LeftFripperTag")
                {
                    SetAngle(this.flickAngle);
                }
            }

            //�������u�Ԃ̏���0
            if (touch0.phase == TouchPhase.Ended)
            {
                Debug.Log("�������u��1�{");
                Vector2 pos0 = touch0.position;
                vec0 = pos0;

                // vec��X���W��0�ȏ�̏ꍇ�����ŉE�t���b�p�[�߂�
                if (vec0.x >= 540 && tag == "RightFripperTag")
                {
                    SetAngle(this.defaultAngle);
                }

                // vec��X���W��0�ȉ��̏ꍇ�����ō��t���b�p�[�߂�
                if (vec0.x <= 540 && tag == "LeftFripperTag")
                {
                    SetAngle(this.defaultAngle);
                }
            }
        }

        if (Input.touchCount > 1)
        {
            // �^�b�`���̎擾0
            Touch touch0 = Input.GetTouch(0);
            // �^�b�`���̎擾1
            Touch touch1 = Input.GetTouch(1);

            //�������u�Ԃ̏���0
            if (touch0.phase == TouchPhase.Began)
            {
                Debug.Log("�������u��2�{��1");
                Vector2 pos0 = touch0.position;
                vec0 = pos0;

                // vec��X���W��0�ȏ�̏ꍇ�^�b�v�ŉE�t���b�p�[����
                if (vec0.x >= 540 && tag == "RightFripperTag")
                {
                    SetAngle(this.flickAngle);
                }

                // vec��X���W��0�ȉ��̏ꍇ�^�b�v�ō��t���b�p�[����
                if (vec0.x <= 540 && tag == "LeftFripperTag")
                {
                    SetAngle(this.flickAngle);
                }
            }
            //�������u�Ԃ̏���0
            if (touch0.phase == TouchPhase.Ended)
            {
                Debug.Log("�������u��2�{��1");
                Vector2 pos0 = touch0.position;
                vec0 = pos0;

                // vec��X���W��0�ȏ�̏ꍇ�����ŉE�t���b�p�[�߂�
                if (vec0.x >= 540 && tag == "RightFripperTag")
                {
                    SetAngle(this.defaultAngle);
                }

                // vec��X���W��0�ȉ��̏ꍇ�����ō��t���b�p�[�߂�
                if (vec0.x <= 540 && tag == "LeftFripperTag")
                {
                    SetAngle(this.defaultAngle);
                }
            }
            //�������u�Ԃ̏���1
            if (touch1.phase == TouchPhase.Began)
            {
                Debug.Log("�������u��2�{��2");
                Vector2 pos1 = touch1.position;
                vec1 = pos1;

                // vec��X���W��0�ȏ�̏ꍇ�^�b�v�ŉE�t���b�p�[����
                if (vec1.x >= 540 && tag == "RightFripperTag")
                {
                    SetAngle(this.flickAngle);
                }

                // vec��X���W��0�ȉ��̏ꍇ�^�b�v�ō��t���b�p�[����
                if (vec1.x <= 540 && tag == "LeftFripperTag")
                {
                    SetAngle(this.flickAngle);
                }
            }
            //�������u�Ԃ̏���1
            if (touch1.phase == TouchPhase.Ended)
            {
                Debug.Log("�������u��2�{��2");
                Vector2 pos1 = touch0.position;
                vec1 = pos1;

                // vec��X���W��0�ȏ�̏ꍇ�����ŉE�t���b�p�[�߂�
                if (vec1.x >= 540 && tag == "RightFripperTag")
                {
                    SetAngle(this.defaultAngle);
                }

                // vec��X���W��0�ȉ��̏ꍇ�����ō��t���b�p�[�߂�
                if (vec1.x <= 540 && tag == "LeftFripperTag")
                {
                    SetAngle(this.defaultAngle);
                }
            }
        }       
     }

    //�t���b�p�[�̌X����ݒ�
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}
