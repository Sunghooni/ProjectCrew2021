using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public PlayerMove playerMove;
    public GameObject deadCanvas;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            deadCanvas.SetActive(true);
            playerMove.canInput = false;
        }
    }
}
