using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Item // enum 열거하다
{
    Weapon,
    Shield,
    Potion, // 마침표 아니고 콤마(,)로 마무리 해주면 됨.
}

public class Part11C : MonoBehaviour
{
    Item item;

    // Start is called before the first frame update
    void Start()
    {
        item = Item.Weapon; // 넣고 싶은 값만 고를 수 있음. 다른걸 넣으면 오류 뜸. 엉뚱한 자료가 뜨지않게 선택지를 준다고 생각하면 됨.
        item = Item.Shield;

        print(item); // 마지막에 Shield 입력했으니까 Shield가 출력되겠지.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
