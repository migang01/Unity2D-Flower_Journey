using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flag : MonoBehaviour
{
    private float timer = 0;
    private float maxTime = .5f;
    private Animator anim;
    public GameManager gameManager;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Player.isGoal == true)
        {
            anim.SetBool("bloom", true);
            if(timer>maxTime)
            {
                gameManager.Goal();
            }
            timer += Time.deltaTime;
           
            
        }
    }
}
