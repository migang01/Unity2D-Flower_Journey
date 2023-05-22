using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    private Animator anim;
    public static bool isDisappeared;
    public float speed = 3;

    private Transform MonsterFlower;

    private float Timer = 0;
    private double maxTime = .5;
    private void Start()
    {
        isDisappeared = false;
        anim = GetComponent<Animator>();
        MonsterFlower = GameObject.FindGameObjectWithTag("Monster Water Zone").transform;
    }

    private void Update()
    {
        Vector3 direction = MonsterFlower.position - transform.position;
        
        
        if (MonsterFlowerBloom.MonsteritBloomed == true)        
        {
            // use click to move method
            anim.SetTrigger("RemoveCollider");
            transform.position = Vector2.MoveTowards(transform.position, MonsterFlower.position, speed * Time.deltaTime);
            
            if (Timer > maxTime)
            { 
                // disappear animiaton
                anim.SetTrigger("Disappear");      
            }
            Timer += Time.deltaTime;
            isDisappeared = true;
        }        
    }    
}
