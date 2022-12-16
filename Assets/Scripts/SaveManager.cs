using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    public Text nameText;
    public Text scoreText;
    public Text positionText;

    public string userName;
    public int userScorce;
    public Vector3 userPosition; 
    
    void Start()
    {
        LoadData();
    }

    void LoadData()
    {
        nameText.text = "User Name: " + PlayerPrefs.GetString("name", "No Name");
        scoreText.text = "User Score: " + PlayerPrefs.GetInt("score", 10).ToString();
        positionText.text = "User Position: " + PlayerPrefs.GetFloat("posX", 1).ToString() + "x " + PlayerPrefs.GetFloat("posY", 1).ToString() + "y " + PlayerPrefs.GetFloat("posZ", 1).ToString() + "z "; 
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("name", userName);
        PlayerPrefs.SetInt("score", userScorce);
        PlayerPrefs.SetFloat("posX", userPosition.x);
        PlayerPrefs.SetFloat("posY", userPosition.y);
        PlayerPrefs.SetFloat("posZ", userPosition.z);

        LoadData();
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("name");
        PlayerPrefs.DeleteKey("score");
        PlayerPrefs.DeleteKey("position");
        PlayerPrefs.DeleteKey("posX");
        PlayerPrefs.DeleteKey("posY");
        PlayerPrefs.DeleteKey("posZ");

        PlayerPrefs.DeleteAll();

        LoadData();
    }

    

    
    
}
