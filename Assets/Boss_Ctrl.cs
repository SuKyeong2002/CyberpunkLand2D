using System.Collections;
using UnityEngine;

public class Boss_Ctrl : MonoBehaviour
{
    float currentTime = 0;    
    float offsetTime = 3;
    float walkTime = 2.5F; 
    float throwTime = 0.5f; 

    public GameObject pfBall;
    public Animator bossAnim;
    GameObject child;
    public GameObject pfBoss;

    void Start()
    {
        child = transform.GetChild(0).gameObject;
        StartCoroutine(BossRoutine());
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > offsetTime) 
        {
            Instantiate(pfBoss, transform.position, transform.rotation);
            currentTime = 0;
        }
    }

    IEnumerator BossRoutine()
    {
        while (true)
        {
            yield return StartCoroutine(BossWalk());
            yield return new WaitForSeconds(0.3f);

            yield return StartCoroutine(BossThrow());
            yield return new WaitForSeconds(throwTime);
        }
    }

    IEnumerator BossWalk()
    {
        bossAnim.SetBool("isRun", true);
        yield return new WaitForSeconds(walkTime);
        bossAnim.SetBool("isRun", false);
        yield return null;
    }

    IEnumerator BossThrow()
    {
        bossAnim.SetBool("isThrow", true);
        yield return new WaitForSeconds(throwTime);
        bossAnim.SetBool("isThrow", false);
        yield return null;
    }

    void makeBall()
    {
        Instantiate(pfBall, child.transform.position, child.transform.rotation);
    }
}