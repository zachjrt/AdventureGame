using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Firefighter : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void Start()
    {
        
    }
    public void firedeath()
    {
        SceneManager.LoadScene("Firedeath");
    }
    public void knight()
    {
        SceneManager.LoadScene("Knight");
    }
}
