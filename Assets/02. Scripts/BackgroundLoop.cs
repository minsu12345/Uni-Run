using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    private float width;//배경의 가로길이
    // Start is called before the first frame update
    private void Awake()
    {
        //가로 길이를 측정하는 처리
        //BoxCollider2D컴포넌트의 size필드의
        //x값을 가로 길이로 사용
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;
    }


    // Update is called once per frame
    void Update()
    {
        //현재 위치가 원점에서 왼쪽으로 width 이상 이동했을때
        if(transform.position.x <= -width)
        {
            Reposition();
        }
    }

    //위치를 재배치하는 메서드
    private void Reposition()
    {
        //위치를 재배치하는 메서드
        //현재 위치에서 오른쪽으로 가로길이 *2만큼 이동
        Vector2 offset = new Vector2(width * 2, 0);
        transform.position = (Vector2)transform.position + offset;
    }
}
