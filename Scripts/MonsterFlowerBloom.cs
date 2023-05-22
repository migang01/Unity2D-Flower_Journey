using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFlowerBloom : MonoBehaviour
{
    private Animator anim;
    public static bool MonsteritBloomed;
    public static bool playerInMFlower;


    private void Start()
    {
        playerInMFlower = false;
        MonsteritBloomed = false;
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Player.isWatering == true && playerInMFlower == true)
        {
            Audio.bloomingSoundPlay();
            anim.SetTrigger("MonsterBlooming");
            MonsteritBloomed = true;

            if(Bug.isDisappeared == true)
            {
                anim.SetTrigger("Eating");
                Bug.isDisappeared = false;
            }     
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerInMFlower = true;   
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInMFlower = false;
        }
    }


}
