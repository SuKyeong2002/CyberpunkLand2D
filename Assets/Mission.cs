using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mission : MonoBehaviour
{
    GameObject victoryPanel;
    GetKey portalKey;

    void Start()
    {
        victoryPanel = GameObject.Find("Victory");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        victoryPanel.GetComponent<Image>().enabled = true;
        StartCoroutine(LoadMainSceneAfterDelay(7.0f));
    }

    IEnumerator LoadMainSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Main");
    }
}
