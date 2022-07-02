using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Forest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void path()
    {
        SceneManager.LoadScene("Path");
    }
    public void lake()
    {
        SceneManager.LoadScene("Lake");
    }
}
