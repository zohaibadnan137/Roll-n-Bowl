using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1Loader : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene("Level1");
    }
}
