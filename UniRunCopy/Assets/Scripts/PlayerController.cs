using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PlayerController�� �÷��̾� ĳ���ͷμ� Player ���� ������Ʈ�� ������
public class PlayerController : MonoBehaviour
{
    public AudioClip deathClip; // ��� �� ����� ����� Ŭ��
    public float jumpForce = 700f; // ���� ��

    private int JumpCount = 0; // ���� ���� Ƚ��
    private bool isGrounde = false; // ����� �ִϸ����� ������Ʈ
    private bool isDead = false; // ����� ����� �ҽ� ������Ʈ

    private Rigidbody2D playerRigidbody;
    private Animator animator;
    private AudioSource playerAudio;

    private void Start ()
    {
        // �ʱ�ȭ
    }

    private void Update()
    {
        // ������� �Է��� �����ϰ� �����ϴ� ó��
    }

    private void Die()
    {
        // ��� ó��
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Ʈ���� �ݶ��̴��� ���� ��ֹ����� �浹�� ����
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �ٴڿ� ������� �����ϴ� ó��
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        // �ٴڿ��� ������� �����ϴ� ó��
    }
}
