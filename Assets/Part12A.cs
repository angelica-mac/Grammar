using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part12A : MonoBehaviour
{
    public delegate void ChainFuction(int value);
    public static event ChainFuction Onstart; // 타 class(Part12B)까지 함수를 관리감독할 수 있다.
    //ChainFuction chain;           //chainfuction을 event로 받아왔기 때문에 필요 없음. 삭제.

    int power;
    int defence;

    public void SetPower(int value)
    {
        power += value;
        print("power의 값이" + value +"만큼 증가하였습니다. 총 power의 값 =" + power);
    }

        public void SetDefence(int value)
    {
        defence += value;
        print("defence의 값이" + value +"만큼 증가하였습니다. 총 defence의 값 =" + defence);
    }

    // Start is called before the first frame update
    void Start()
    {
        // SetPower(5);
        // SetDefence(5);  chain으로 바꿔줄거임.

        Onstart += SetPower;    // "="으로 입력하면 '우항'의 함수만 적용됨. 
        Onstart += SetDefence;  // chain을 Onstart로 변경

        // Onstart -= SetPower;
        // Onstart -= SetDefence;
        // if(Onstart != null)

        Onstart(5);
    }

    private void OnDisable() // OnDisable 호출 안됨. 안불러와져도 작동은 된대.
    {
        Onstart(5);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
