using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VideoSceneEngine : MonoBehaviour
{
    public Button MenuBtn;

    private void Awake()
    {
        MenuBtn.onClick.AddListener(GoToMenu);
    }

    void GoToMenu() {
        SceneManager.LoadScene("SampleScene");
    }
}
