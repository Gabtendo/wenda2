using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScenePlease: MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("WendaCutscene1");
    }
}
