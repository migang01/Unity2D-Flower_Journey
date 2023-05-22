using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerBloom : MonoBehaviour
{

    private Animator anim;
    public static bool itBloomed;
    public static bool playerInFlower;    

    private void Start()
    {
        playerInFlower = false;
        itBloomed = false;
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Player.isWatering == true && playerInFlower == true && !itBloomed)
        {
            Audio.bloomingSoundPlay();
            // fixed by adding "!itBloomed" in if statement so the "Blooming" sound doens't loop
            anim.SetTrigger("Blooming");
            itBloomed = true;
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInFlower = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInFlower = false;
        }
    }
}
