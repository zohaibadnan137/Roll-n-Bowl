using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsLoader : MonoBehaviour
{
    public void LoadInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}
