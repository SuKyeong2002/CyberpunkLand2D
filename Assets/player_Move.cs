using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player_Move : MonoBehaviour
{
    // ĳ���� �¿� �����̴� ����
    float moveLR = 0;
    float speed = 5.0f;
    Animator playerAni;
    Rigidbody2D playerRigid;
    public bool getKey = false;
    public float hp = 1;

    void Start()
    {
        playerAni = GetComponent<Animator>();
        playerRigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ĳ���� �¿� ������
        moveLR = Input.GetAxisRaw("Horizontal");
        transform.Translate(transform.right * moveLR * Time.deltaTime * speed);

        // ĳ���� ���� ������
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerRigid.velocity = new Vector2(playerRigid.velocity.x, 0); // Y축 속도를 초기화
            playerRigid.AddForce(new Vector2(0, 0.5f), ForceMode2D.Impulse);
            playerAni.SetBool("isJump", true);
        } 
        else
        {
            playerAni.SetBool("isJump", false);

            if (playerRigid.velocity.y != 0)
            {
                playerAni.SetBool("isJump", true);
            }
        }


        // ĳ���� �޸��� �ִϸ��̼�
        if (moveLR == -1 || moveLR == 1)
        {
            playerAni.SetBool("isRun", true);
            if(playerRigid.velocity.y != 0)
            {
                playerAni.SetBool("isJump", true);
                playerAni.SetBool("isRun", false);
            } 
        }
        else
        {
            playerAni.SetBool("isRun", false);
        }
        // ĳ���� �¿� ����

        if(moveLR == -1)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }else if(moveLR == 1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Water") {
            Destroy(gameObject);
            SceneManager.LoadScene("End");
        }
        if (other.gameObject.tag == "Boss") {
            hp = hp - 0.5f;
            if(hp <= 0) {
                Destroy (gameObject);
                SceneManager.LoadScene("End");
            }
            StartCoroutine(DamageEffect());
            Debug.Log("보스랑 부딪혔다");
        }
        if (other.gameObject.tag == "Hulk") {
            hp = hp - 0.3f;
            if(hp <= 0) {
                Destroy (gameObject);
                SceneManager.LoadScene("End");
            }
            StartCoroutine(DamageEffect());
            Debug.Log("헐크랑 부딪혔다");
        }
         if (other.gameObject.tag == "Spider") {
            hp = hp - 0.1f;
            if(hp <= 0) {
                Destroy (gameObject);
                SceneManager.LoadScene("End");
            }
            StartCoroutine(DamageEffect());
            Debug.Log("스파이더랑 부딪혔다");
        }
        
        if (other.gameObject.tag == "Bomb") {
            StartCoroutine(DamageEffect());
            hp = hp - 0.1f;
            if(hp <= 0) {
                Destroy (gameObject);
                SceneManager.LoadScene("End");
            }
            Debug.Log("-10");
        }
        
        if (other.gameObject.tag == "Key") {
            Destroy(other.gameObject);
            getKey = true;
        }  
        if (other.gameObject.tag == "Life") {
            hp = hp + 0.2f;
            Destroy(other.gameObject);
        }
    }

     void OnCollisionEnter2D(Collision2D other) 
     {
        if (other.gameObject.tag == "Ball") {
            hp = hp - 0.3f;
            if(hp <= 0) {
                Destroy (gameObject);
                SceneManager.LoadScene("End");
                // Time.timeScale = 0.0f;
            }
            StartCoroutine(DamageEffect());
        }
     }

    IEnumerator DamageEffect() 
    {
        GetComponent<SpriteRenderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        GetComponent<SpriteRenderer>().material.color = Color.white;
        yield return new WaitForSeconds(0.2f);
    }
}