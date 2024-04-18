using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloadManager : MonoBehaviour
{
    public TextMeshProUGUI texti;
    public static int activeScene;
    // Start is called before the first frame update
    void Start()
    {//resetar health og unlockar cursor
        playerpoints.health = 10;
        Cursor.lockState = CursorLockMode.None;
        if (activeScene == 2)
        {
            if (playerpoints.points > 30)
            {
                texti.text = " vel gert heimaveröldinn er stolt. þu fékkst" + playerpoints.points + " stig";
            }
            else { 
            texti.text = "þú fékkst " + playerpoints.points + " stig";}
        }
    }

    // Update is called once per frame
    void Update()//ætlaði að gera eithvað meria með etta
        //endaði bara sem eithvað til að gera lif mitt aðeins lettara
        //eg nenti ekki að muna nr hvað hvert scene var
    {
        
    }
    public static void lvl1()
    {   
        SceneManager.LoadScene(1);
        activeScene = 1;
    }
    public static void mainMenu()
    { SceneManager.LoadScene(0);
        activeScene = 0;}
    public static void gameOver() 
    { SceneManager.LoadScene(2);
        activeScene = 2;
    }
}
