using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        string name = GetComponentInChildren<TMP_InputField>().text;
        if (name != "")
        {
            DataManager.Instance.PlayerName = name;
            SceneManager.LoadScene(1);
        }
    }
}
