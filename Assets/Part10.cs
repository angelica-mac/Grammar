using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Angelica.studio;
using Angelica;

// namespace - 협업, 대형 프로젝트, 외부 라이브러리.
//             중복문제 해결.

namespace Angelica
{
    public class Youtube  // class의 이름이 같은경우에는 namespace로 분류한다.
    {
        public int subscribe;
    }

    namespace studio
    {
        public class Youtube
        {
            int like;

            public void SetLike(int value) // 변수형 void
            {
                like = value;
            }
            public bool IsLike()  // True False 타입은 bool
            {
                return like != 0;
            }
        }
    }
}



public class Part10 : MonoBehaviour
{
    Angelica.Youtube Angelica = new Angelica.Youtube();


    // Start is called before the first frame update
    void Start()
    {
        Angelica.subscribe = 5;
        print(Angelica.subscribe);


     //   Angelica.SetLike(5);
     //   print(Angelica.IsLike()); // true
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
