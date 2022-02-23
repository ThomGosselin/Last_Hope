using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrectNumberGame : MonoBehaviour
{
    [Header("Input Field")]
    public InputField NumberInputFromUser;
    [Header("Number To Find")]
    public string NumberToFind;
    [Header("Closing Game Section")]
    public GameObject GameGrid;
    public GameObject Player;
    public GameObject xBtn;
    public GameObject Canvas;
    public GameObject Ingrediant;


    private void Update()
    {
        if (NumberInputFromUser.text == NumberToFind)
        {
            FindObjectOfType<AudioManager>().Play("SuccedMiniGame");
            GameGrid.SetActive(false);
            Canvas.SetActive(false);
            Player.SetActive(true);
            xBtn.SetActive(false);
            Ingrediant.SetActive(true);
            FindObjectOfType<LastEnigmeManager>().Enigme2Complete = true;
        }
    }

}
