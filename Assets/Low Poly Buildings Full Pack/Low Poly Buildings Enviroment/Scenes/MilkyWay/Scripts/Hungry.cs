using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hungry: MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("WendaCutscene4");
    }
}
