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
    public int passwordLength;
    public int userPassLength;
    public GameObject currentcomptuerScreen;
    public GameObject desktop;
    public GameObject cameraScreen;
    public GameObject xBtn;

    // Update is called once per frame
    void Update()
    {
        if (userInput.text.Length == passwordLength)
        {
            checkWin();
        }
    }

    private void checkWin()
    {
        if (userInput.text == passcode)
        {
            FindObjectOfType<AudioManager>().Play("SuccedMiniGame");
            currentcomptuerScreen.SetActive(false);
            currentcomptuerScreen.SetActive(false);
            cameraScreen.SetActive(true);
            xBtn.SetActive(true);
        }
        else
        {
            userInput.text = "";
        }
    }
}
