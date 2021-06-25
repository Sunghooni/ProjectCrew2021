using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartOnClicked()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void ExitOnClicked()
    {
        Application.Quit();
    }
}
