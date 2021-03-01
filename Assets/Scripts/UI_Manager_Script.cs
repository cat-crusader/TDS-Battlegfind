using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager_Script : MonoBehaviour
{
    public static UI_Manager_Script instance;
    public GameObject startMenu;
    public InputField usernameField;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else if (instance != this)
        {
            Debug.Log("Instance allready exist, destroy object");
            Destroy(this);
        }
    }

    public void ConnectToServer()
    {
        startMenu.SetActive(false);
        usernameField.interactable = false;
        Client_Script.instance.ConnectToServer();
    }
}
