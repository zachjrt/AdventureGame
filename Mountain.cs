using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mountain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void forest()
    {
        SceneManager.LoadScene("Forest");
    }
    public void dragon()
    {
        SceneManager.LoadScene("Dragon");
    }
}
