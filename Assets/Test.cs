using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss 
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����
    private int mp = 53; //�}�W�b�N�|�C���g

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

    //���@�̊֐�
    public void Magic(int point)
    {
        if (mp >= 5)
        {
            Debug.Log("����������Ȃ����߁A���@���g���Ȃ�");
        }
        else
        {
            Debug.Log("���@�U���������A�c�肈���́���");
            //�@�c��mp�����炷
            this.mp -= point;
        }
    }

    

}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);
        // ���@�p�̊֐����Ăяo��
        for (int a = 0; a < 11; a++)
        {
            lastboss.Magic(5);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
