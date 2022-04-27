using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HDropLuc : MonoBehaviour
{
    public void Dropdown(int value)
    {
        if (value == 0)
        {
            SceneManager.LoadScene("luc-main");
        }
        if (value == 1)
        {
            SceneManager.LoadScene("ora-main");
        }
        if (value == 2)
        {
            SceneManager.LoadScene("giz-main");
        }
        if (value == 3)
        {
           
            SceneManager.LoadScene("fio-main");
        }
        if (value == 4)
        {
            SceneManager.LoadScene("mik-main");
        }
        if (value == 5)
        {
            SceneManager.LoadScene("mar-main");
        }
        if (value == 6)
        {
            SceneManager.LoadScene("MainMenu");
        }

    }


}
