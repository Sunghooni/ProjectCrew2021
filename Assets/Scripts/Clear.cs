using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    public PlayerMove playerMove;
    public GameObject ClearPanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && !playerMove.canInput)
        {
            SceneManager.LoadScene("PlayScene");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            playerMove.canInput = false;
            ClearPanel.SetActive(true);
        }
    }
}
