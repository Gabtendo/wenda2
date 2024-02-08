using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItchMe: MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("SAVED");
    }
}
