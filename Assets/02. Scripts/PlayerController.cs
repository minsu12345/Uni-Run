using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip deathClip; //사망시 재생할 오디오 클립
    public float jumpForce = 700f; //점프힘

    private int jumpCount = 0; //누적점프 횟수
    private bool isGrounded = false; //바닥에 닿았는지 나타냄
    private bool isDead = false; //사망 상태
    private Rigidbody2D playerRigidbody; //사용할 리지드바디컴포넌트
    private Animator animator; //사용할 애니메이터 컴포넌트
    private AudioSource playerAudiol; //사용할 오디오 소스 컴포넌트
    // Start is called before the first frame update
    void Start()
    {
        //초기화
    }

    // Update is called once per frame
    void Update()
    {
        //사용자 입력을 감지하고 점프하는 처리
    }
    private void Die()
    {
        //사망처리
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //바닥에 닿았음을 감지하는 처리
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //바닥에서 벗어났음 감지하는 처리
    }
}
