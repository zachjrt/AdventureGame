using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void swim()
    {
        SceneManager.LoadScene("Swim");
    }
    public void cliff()
    {
        SceneManager.LoadScene("Cliff");
    }
}
