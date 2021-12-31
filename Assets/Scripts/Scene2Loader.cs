using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2Loader : MonoBehaviour
{
    public void LoadScene2()
    {
        SceneManager.LoadScene("Level2");
    }
}
