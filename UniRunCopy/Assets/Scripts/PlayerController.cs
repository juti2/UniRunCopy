using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip deathClip; //��� �� ��� �� ����� Ŭ�� 
    // Start is called before the first frame update
    public float jumpForce = 700f; //���� ��
    private int jumpCount = 0; //���� ���� Ƚ��
    private bool isGrounded = false; //�ٴڿ� ��Ҵ��� ��Ÿ��
    private bool isDead = false; //��� ����

    private Rigidbody2D playerRigidbody; //����� ������ �ٵ� ������Ʈ
    private Animator animator; //����� ������ٵ� ������Ʈ
    private AudioSource playerAudio; //����� ����� �ҽ� ������Ʈ

    private void Start() //�ʱ�ȭ
    {

    }

    private void Update() //����� �Է��� �����ϰ� �����ϴ� �Ÿ�
    {

    }

    private void Die() // ���ó��
    {

    }

    private void OnTriggerEnter2D(Collider2D other) // Ʈ���� �ݶ��̴��� ���� ��ֹ����� �浹�� ����
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) // �ٴڿ� ������� �����ϴ� �Ÿ�
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision) // �ٴڿ��� ������� �����ϴ� �Ÿ�
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}