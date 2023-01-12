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

    [SerializeField]
    private Text countText;

    public int count;


    public void Start()
    {
        count = 0;
        countText.text = "Count: 0";
    }

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

    public void Zurueck()
    {
        if (lose.lost == true)
        {
            count = 0;
            a.SetTrigger("fin");
        }
    }

    /* public void ChangeLevel(int i)
    {
        if (i == 0)
        {
            Debug.Log("Null");
            animator.SetTrigger("Return");
            a.SetTrigger("ohno");
        }

        if (i == 1)
        {
            animator.SetTrigger("Level2");
        }

        if (i == 2)
        {
            animator.SetTrigger("Level3");
        }
    } */

    public void Update()
    {
        if (count == 0)
        {
            Debug.Log("Null");
            animator.SetTrigger("Return");
        }

        if (count == 1)
        {
            Debug.Log("Eins");
            animator.SetTrigger("Level1");
        }

        if (count == 2)
        {
            Debug.Log("Zwei");
            animator.SetTrigger("Level2");
        }

        if (count == 2)
        {
            Debug.Log("You Win!");
        }
    }

    /*
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
    }  */
}
