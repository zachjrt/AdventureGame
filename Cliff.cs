using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cliff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void remains()
    {
        SceneManager.LoadScene("Remains");
    }
    public void mountain()
    {
        SceneManager.LoadScene("Mountain");
    }
}
