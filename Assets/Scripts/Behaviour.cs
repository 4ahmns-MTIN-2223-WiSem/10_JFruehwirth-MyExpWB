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

    public TextMesh countText; // kann keinen 3D Text im Inspector einbinden

    public int count;

    public GameObject bear;

    public List<GameObject> noButtonPress;
    public GameObject pressStart;
    public GameObject pressInteract;
    public GameObject pressStop;

    public void Start()
    {
        count = 0;
        countText.text = "Count: 0";
    }

    /* public void StartGame()
    {
        animator.enabled = true;
        a.enabled = true;
    } */

    /* public void InteractGame()
    {
        a.SetTrigger("pressed");
    } */

    public Animator animator;

    /*public void Zurueck()
    {
        if (lose.lost == true)
        {
            count = 0;
            a.SetTrigger("fin");
        }
    }*/

    /* public void onClick()
    {
        if (win == true)
        {
            Debug.Log("Jura");
        }
    } */

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
            //animator.SetTrigger("Return");
        }

        if (count == 1)
        {
            Debug.Log("Eins");
            animator.SetTrigger("Level2");
            countText.text = "Count: 1";
        }

        if (count == 2)
        {
            Debug.Log("Zwei");
            animator.SetTrigger("Level3");
            countText.text = "Count: 2";
        }

        if (count == 3)
        {
            Debug.Log("You Win!");
            countText.text = "You Win!";
            animator.SetTrigger("Fin");
            bear.SetActive(true);
        }

        /* if (a.SetTrigger() == a.SetTrigger("pressed") & win == true)
        {
            count++;
        } */
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
