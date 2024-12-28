using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void GotoMainScene()
    {
        SceneManager.LoadScene("crystal_level");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
