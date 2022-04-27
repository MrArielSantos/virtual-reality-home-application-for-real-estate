using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphere;
    // Start is called before the first frame update
    public void open()
    {
        if (sphere != null)
        {
            Animator animator = sphere.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open");

                animator.SetBool("open", !isOpen);
            }
        }


    }
}