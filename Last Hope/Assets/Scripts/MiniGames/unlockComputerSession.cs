using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



//1628 <- code du cadenas
public class unlockComputerSession : MonoBehaviour
{

    public InputField userInput;

    private string userPassword;
    public string passcode;
    public GameObject currentcomptuerScreen;
    public GameObject desktop;
    public GameObject xBtn;

    // Update is called once per frame
    void Update()
    {
        userPassword = userInput.text;
        if (userPassword == passcode)
        {
            FindObjectOfType<AudioManager>().Play("SuccedMiniGame");
            currentcomptuerScreen.SetActive(false);
            desktop.SetActive(true);
        }
    }
}
