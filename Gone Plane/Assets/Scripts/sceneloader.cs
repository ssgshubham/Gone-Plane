using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    public void timepause()
    {
        Time.timeScale = 0f;
    }

    public void timerestart()
    {
        Time.timeScale = 1f;
    }

    public void theme0()
    {
        SceneManager.LoadScene(0);
    }


    public void theme1()
    {
        SceneManager.LoadScene(1);
    }

    public void theme2()
    {
        SceneManager.LoadScene(2);
    }

    public void theme3()
    {
        SceneManager.LoadScene(3);
    }

    public void theme4()
    {
        SceneManager.LoadScene(4);
    }

    public void world1()
    {
        SceneManager.LoadScene(5);
    }

    public void world2()
    {
        SceneManager.LoadScene(6);
    }

    public void world3()
    {
        SceneManager.LoadScene(7);
    }

    public void world4()
    {
        SceneManager.LoadScene(8);
    }

    public void theme5()
    {
        SceneManager.LoadScene(9);
    }

    public void theme6()
    {
        SceneManager.LoadScene(10);
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }


}
