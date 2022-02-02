using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



//1628 <- code du cadenas
public class unlockCadenas : MonoBehaviour
{

    public InputField userInput;
    public string passcode;
    public GameObject cadenasGame;
    public GameObject tiroir;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(userInput.text == passcode)
        {
            FindObjectOfType<AudioManager>().Play("SuccedMiniGame");
            cadenasGame.SetActive(false);
            tiroir.SetActive(true);
        }
    }
}
