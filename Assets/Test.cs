using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //  Use this for initialization
    void Start()
    {
        // �v�f���T�̔z�������������
        int[] array = new int[5];

        //�@�z��̊e�v�f�ɒl��������
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;

        //�@�z��̗v�f�����ׂĕ\������
        for (int a = 0; a < 5; a++)
        {
            Debug.Log(array[a]);
        }
        for (int b = 4; b >= 0; b--)
        {
            Debug.Log(array[b]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class Boss
{
    private int hp = 100;          // �̗�
    private int power =25; // �U����

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        //�̂���HP�����炷
        this.hp -= damage;
    }

}

public class Test: MonoBehaviour
{

    void Start()
    {
        //Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        //�U���p�̊֐����Ăяo��
        lastboss.Attack();
        //�h��p�̊֐����Ăяo��
        lastboss.Defence(3);
    }

    // Update is called once per frame
    void Update()
    {

    }
}