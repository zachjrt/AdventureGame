using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{

    public Text fluffyMittensText;
    public string[] fluffyMittensList;
    private int i = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playGame()
    {
        SceneManager.LoadScene("Intro");
    }

    public void castle()
    {
        SceneManager.LoadScene("Castle");
    }
 

    public void death()
    {
        SceneManager.LoadScene("death");
    }
    public void fluffyMittens()
    {
        if (i <= 38)
        {
            fluffyMittensText.text = fluffyMittensList[i];
            i++;
        }

        if (i >= 39)
        {
            SceneManager.LoadScene("Castle");
        }
       
        
    }

}
