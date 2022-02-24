using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuManager : MonoBehaviour
{
    public GameObject nameField;
    public TextMeshProUGUI bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ShowBestScore();
        nameField.GetComponent<TMP_InputField>().text = PlayerPrefs.GetString("Player"); 
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame() 
    {
        NameBetwScenes.Instance.playerName = nameField.GetComponent<TMP_InputField>().text;

        if (NameBetwScenes.Instance.playerName != "")
        {
            SceneManager.LoadScene(1);
        }
        else 
        {
            Debug.Log("Enter your name!!!");
        }
    }

    public void ResetBestScore() 
    {
        PlayerPrefs.SetInt("BestScore", 0);
        PlayerPrefs.SetString("BestPlayer", "Player");

        ShowBestScore();
    }

    private void ShowBestScore() 
    {
        bestScoreText.text = "Best Score : " + PlayerPrefs.GetString("BestPlayer") + " : " + PlayerPrefs.GetInt("BestScore");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
