using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    void Start()
    {
        // Hello World!�� �ֿܼ� ���
        Debug.Log("����ϰ� ���� ��");

        //ĳ������ �������� ������ �����
        string CharacterName = "���";
        char bloodType = 'A';
        int age = 17;
        float height = 168.3f;
        bool isFemale = true;

        // ������ ������ �ֿܼ� ���
        Debug.Log("ĳ���� �̸� : " + CharacterName);
        Debug.Log($"ĳ���� �̸� : {CharacterName} ");
        Debug.Log("ĳ���� �̸� : ");
        Debug.Log(CharacterName);
        Debug.Log("������ : " + bloodType);
        Debug.Log("���� : " + age);
        Debug.Log("Ű : " + height);
        Debug.Log("�����ΰ�? : " + isFemale);

        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2,2)���� (5,6)������ �Ÿ� : " + distance);

        int love = 80;

        if(love > 90)
        {
            Debug.Log("Ʈ�翣�� : �����ΰ� ��ȥ�ߴ�!");
        }
        else if(love > 70)
        {
            Debug.Log("�¿��� : �����ΰ� ��Ͱ� �Ǿ���.");
        }
        else
        {
            Debug.Log("��忣�� : �����ο��� ������.");
        }

        int age2 = 11;

        if(age2 > 7 && age2 < 18)
        {
            Debug.Log("�ǹ� ������ �ް� �ֽ��ϴ�.");
        }
        if(age2 < 13 || age2 > 70)
        {
            Debug.Log("���� �� �� ���� �����Դϴ�.");
        }

        for(int i = 0; i < 10; i++)
        {
            Debug.Log(i + "��° �����Դϴ�.");
        }

        int j = 0;

        while(j < 10)
        {
            Debug.Log(j + "��° �����Դϴ�.");
            j++;
        }

        bool isDead = false;
        int hp = 100;

        while (!isDead)
        {
            Debug.Log("���� ü�� : " + hp);

            hp -= 33;

            if(hp <= 0)
            {
                isDead = true;
                Debug.Log("�÷��̾�� �׾����ϴ�.");
            }
        }

        int[] students = new int[5];

        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        Debug.Log("0�� �л��� ���� : " + students[0]);
        Debug.Log("1�� �л��� ���� : " + students[1]);
        Debug.Log("2�� �л��� ���� : " + students[2]);
        Debug.Log("3�� �л��� ���� : " + students[3]);
        Debug.Log("4�� �л��� ���� : " + students[4]);

        for(int r = 0; r < students.Length; r++)
        {
            Debug.Log($"{r}�� �л��� ���� : {students[r]}");
        }
    }

    float GetDistance(float x1, float y1, float x2, float y2)
    {
        float Width = x2 - x1;
        float height = y2 - y1;

        float distance = Width * Width + height * height;
        distance = Mathf.Sqrt(distance);

        return distance;
    }
}
