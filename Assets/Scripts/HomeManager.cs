using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
public class HomeManager : MonoBehaviour
{

    public Text nameText;
    public static string plName;
    public Text highscoreText;
    public static Color col;
    // Start is called before the first frame update
    void Start()
    {
        if(name != null)
        {
            nameText.text = plName;
        }
        string json = File.ReadAllText(Application.persistentDataPath + "/savefile.json");
        MainManager.SaveData dat = JsonUtility.FromJson<MainManager.SaveData>(json);
        highscoreText.text = dat.plName + ": " + dat.highscore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBtn()
    {
        plName = nameText.text;
        SceneManager.LoadScene("main");
    }
    public void OnRed()
    {
        col = Color.red;
    }
    public void OnGreen()
    {
        col = Color.green;
    }
    public void OnBlue()
    {
        col = Color.blue;
    }
    public void OnYellow()
    {
        col = Color.yellow;
    }
}
