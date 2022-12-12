using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Behaviour : MonoBehaviour
{
    public Button buttonStart; 
    public Button interactStart;
    public Animator a;
    public LoseQuest lose;
    public WinQuest win;


    public void StartGame()
    {
        animator.enabled = true;
        a.enabled = true;
    }

    public void InteractGame()
    {
        a.SetTrigger("pressed");
    }

    [SerializeField]
    private Animator animator;

    public int i;

    private void ChangeLevel(/*int i*/)
    {
        if (i == 0)
        {
            animator.SetTrigger("Return");
        }
        if (i == 1)
        {
            animator.SetTrigger("Level2");
        }

        if (i == 2)
        {
            animator.SetTrigger("Level3");
        }
    }

    public void Update()
    {
        if (lose.lost == true)
        {
            animator.SetTrigger("Return");
        }

        if (win.won == true && i == 1)
        {
            animator.SetTrigger("Level2");
        }

        if (win.won == true && i == 2)
        {
            animator.SetTrigger("Level3");
        }
    }
}
