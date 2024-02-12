using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    void Start()
    {
        // Hello World!를 콘솔에 출력
        Debug.Log("출력하고 싶은 값");

        //캐릭터의 프로필을 변수로 만들기
        string CharacterName = "라라";
        char bloodType = 'A';
        int age = 17;
        float height = 168.3f;
        bool isFemale = true;

        // 생성한 변수를 콘솔에 출력
        Debug.Log("캐릭터 이름 : " + CharacterName);
        Debug.Log($"캐릭터 이름 : {CharacterName} ");
        Debug.Log("캐릭터 이름 : ");
        Debug.Log(CharacterName);
        Debug.Log("혈액형 : " + bloodType);
        Debug.Log("나이 : " + age);
        Debug.Log("키 : " + height);
        Debug.Log("여성인가? : " + isFemale);

        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2,2)에서 (5,6)까지의 거리 : " + distance);

        int love = 80;

        if(love > 90)
        {
            Debug.Log("트루엔딩 : 히로인과 결혼했다!");
        }
        else if(love > 70)
        {
            Debug.Log("굿엔딩 : 히로인과 사귀게 되었다.");
        }
        else
        {
            Debug.Log("배드엔딩 : 히로인에게 차였다.");
        }

        int age2 = 11;

        if(age2 > 7 && age2 < 18)
        {
            Debug.Log("의무 교육을 받고 있습니다.");
        }
        if(age2 < 13 || age2 > 70)
        {
            Debug.Log("일을 할 수 없는 나이입니다.");
        }

        for(int i = 0; i < 10; i++)
        {
            Debug.Log(i + "번째 순서입니다.");
        }

        int j = 0;

        while(j < 10)
        {
            Debug.Log(j + "번째 루프입니다.");
            j++;
        }

        bool isDead = false;
        int hp = 100;

        while (!isDead)
        {
            Debug.Log("현재 체력 : " + hp);

            hp -= 33;

            if(hp <= 0)
            {
                isDead = true;
                Debug.Log("플레이어는 죽었습니다.");
            }
        }

        int[] students = new int[5];

        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        Debug.Log("0번 학생의 점수 : " + students[0]);
        Debug.Log("1번 학생의 점수 : " + students[1]);
        Debug.Log("2번 학생의 점수 : " + students[2]);
        Debug.Log("3번 학생의 점수 : " + students[3]);
        Debug.Log("4번 학생의 점수 : " + students[4]);

        for(int r = 0; r < students.Length; r++)
        {
            Debug.Log($"{r}번 학생의 점수 : {students[r]}");
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
