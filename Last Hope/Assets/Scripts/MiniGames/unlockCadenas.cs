using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



//1628 <- code du cadenas
public class unlockCadenas : MonoBehaviour
{

    public InputField chiffre1;
    public InputField chiffre2;
    public InputField chiffre3;
    public InputField chiffre4;
    private string userPassword;
    public string passcode;
    public GameObject cadenasGame;
    public GameObject tiroir;
    public GameObject xBtn;

    // Update is called once per frame
    void Update()
    {
        userPassword = chiffre1.text + chiffre2.text + chiffre3.text + chiffre4.text;
        if(userPassword == passcode)
        {
            FindObjectOfType<AudioManager>().Play("SuccedMiniGame");
            cadenasGame.SetActive(false);
            tiroir.SetActive(true);
        }
    }
}
