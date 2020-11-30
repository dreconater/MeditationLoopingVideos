using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainEngine : MonoBehaviour
{
    public List<Button> Items = new List<Button>();

    private void Awake()
    {
        Items[0].onClick.AddListener(() => { ClickedItem(1); });
        Items[1].onClick.AddListener(() => { ClickedItem(2); });
        Items[2].onClick.AddListener(() => { ClickedItem(3); });
    }

    void ClickedItem(int index) {
        SceneManager.LoadScene("VideoScene");
    }
}
