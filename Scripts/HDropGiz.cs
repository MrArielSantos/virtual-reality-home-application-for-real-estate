using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HDropGiz : MonoBehaviour
{
    public void Dropdown(int value)
    {
        if (value == 0)
        {
            SceneManager.LoadScene("giz-main");
        }
        if (value == 1)
        {
            SceneManager.LoadScene("ora-main");
        }
        if (value == 2)
        {
           
            SceneManager.LoadScene("fio-front");
        }
        if (value == 3)
        {
            SceneManager.LoadScene("luc-front");
        }
        if (value == 4)
        {
            SceneManager.LoadScene("mic-main");
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
