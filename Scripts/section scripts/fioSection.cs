using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fioSection : MonoBehaviour
{
    public string living;
    public string kitchen;
    public string master;
    public string bedroom;
    public string family;
    public string cr;
    public string dining;
    public string veranda;
    public string carport;

    public void Dropdown(int value)
    {
        if (value == 0)
        {
            
        }
        if (value == 1)
        {

            SceneManager.LoadScene(living);
        }
        if (value == 2)
        {
            SceneManager.LoadScene(kitchen);
        }
        if (value == 3)
        {
            SceneManager.LoadScene(master);
        }
        if (value == 4)
        {
            SceneManager.LoadScene(bedroom);
        }
        if (value == 5)
        {
            SceneManager.LoadScene(family);
        }
        if (value == 6)
        {
            SceneManager.LoadScene(cr);
        }
        if (value == 7)
        {
            SceneManager.LoadScene(dining);
        }
        if (value == 8)
        {
            SceneManager.LoadScene(veranda);
        }
        if (value == 9)
        {
            SceneManager.LoadScene(carport);
        }

    }


}