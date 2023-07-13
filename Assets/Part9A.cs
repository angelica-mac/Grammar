using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part9A : MonoBehaviour
{
    // 컬렉션 : 리스트, 큐, 스택, 해시테이블, 딕셔너리, 어레이리스트

    int[] exp = new int[5]{1,2,3,4,5};

    // ArrayList
    ArrayList arrayList = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add("가나다");
        arrayList.Add(4.5);

        print(arrayList.Count); // 5개 추가했으니까 5 // ArrayList는 Length없음. 대신 Count
        
        arrayList.Remove("가나다");
        arrayList.RemoveAt(3); // 인덱스로 지우기 // 25번줄에서 3번 인덱스 지웠으니까 4.5 가 다시 인덱스 3이 되는거지
        arrayList.RemoveRange(1,1); // 범위로 지우기 (인덱스번호, 범위)

        arrayList[1] = 4; // 수정하고 싶은 인덱스 선택해서 값 입력해주면 됨.

        print(arrayList.Contains(1)); // 특정값이 있는지 없는지 확인하는 메소드. 있으면 True로 반환됨. // 인덱스 번호가 아니라 값을 입력.
    //  arrayList.CopyTo // arrayList를 복사해서 다른 arrayList에 그대로 집어넣는 메소드.
    //  arrayList.Equals // 특정값과 같느냐 안같느냐
    //  arrayList.GetRange // 특정범위를 뽑아낼 수도 있고
    //  arrayList.IndexOf // 인덱스를 통해서 특정값을 불러올 수도 있음.

        arrayList.Insert(1,1.5); // 중간에 끼워넣기.

        arrayList.Clear(); // 초기화

        for (int i = 0; i < arrayList.Count; i++) // 윈도우는 더블탭하면 자동완성 되는거 같은데 mac은 어떻게 하는지 모르겠네.
        {
            print(arrayList[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
