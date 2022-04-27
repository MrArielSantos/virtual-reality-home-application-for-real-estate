using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Section : MonoBehaviour
{
    public string section1;
    public string section2;
    public string section3;
    public string section4;
    public string section5;
    public string section6;
    public string section7;
    public string section8;
    public string section9;

    public void Dropdown(int value)
    {
        if (value == 0)
        {

        }
        if (value == 1)
        {

            SceneManager.LoadScene(section1);
        }
        if (value == 2)
        {
            SceneManager.LoadScene(section2);
        }
        if (value == 3)
        {
            SceneManager.LoadScene(section3);
        }
        if (value == 4)
        {
            SceneManager.LoadScene(section4);
        }
        if (value == 5)
        {
            SceneManager.LoadScene(section5);
        }
        if (value == 6)
        {
            SceneManager.LoadScene(section6);
        }
        if (value == 7)
        {
            SceneManager.LoadScene(section7);
        }
        if (value == 8)
        {
            SceneManager.LoadScene(section8);
        }
        if (value == 9)
        {
            SceneManager.LoadScene(section9);
        }

    }


}