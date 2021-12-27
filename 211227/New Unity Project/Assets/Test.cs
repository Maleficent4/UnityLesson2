using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    void Start()
    {
        print("Hello Unity");
    }

    void Update()
    {

    }

    public void SceneChange()
    {
        SceneManager.LoadScene("Play");
    }
}
