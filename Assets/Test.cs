using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        this.hp -= power;
    }

    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp�@+ "�B");
        }

        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 10, 20, 30, 70, 80 };

        for (int i = 0; i < array.Length ; i++)
        {
            Debug.Log(array[i]);
        }

        for ( int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }


        Boss lastboss = new Boss();

        lastboss.Attack();

        lastboss.Defence(3);

        for( int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }

        lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
