using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelShow : MonoBehaviour
{
    public static int level;
    public Text levelText;

    private void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex - 2;
    }
    private void Update()
    {
        if(level<=5)
        {
            levelText.text = "Level 1-" + level;
        }
       
        if(level>5 && level <=10)
        {
            levelText.text = "Level 2-" + (level-5);
        }

        if(level>10 && level <= 15)
        {
            levelText.text = "Level 3-" + (level-10);
        }
    }
}
