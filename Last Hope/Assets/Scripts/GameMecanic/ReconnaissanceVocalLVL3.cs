using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;

public class ReconnaissanceVocalLVL3 : MonoBehaviour
{
    [Header("Éléments pour la reconnaissance vocal")]
    private Dictionary<string, Action> keywordActions = new Dictionary<string, Action>();
    private KeywordRecognizer keywordRecognizer;
    [Header("Éléments de l'enigme 2")]
    public GameObject secretDoor;
    [Header("Éléments de l'enigme 3")]
    public string VoiceMailPassword;
    public string UserVoiceMailPassWord;
    public int CurrentPasswordLenght;
    public int lenghtOfCurrentTry;
    public GameObject Player;
    void Start()
    {
        CurrentPasswordLenght = VoiceMailPassword.Length;
        //Ajout des mots clefs pour la reconnaissance vocal
        keywordActions.Add("dernier espoir", OpenDoorLvl3);
        keywordActions.Add("last hope", OpenDoorLvl3);
        keywordActions.Add("7", AddToVoiceMailPassword7);
        keywordActions.Add("5", AddToVoiceMailPassword5);
        keywordActions.Add("8", AddToVoiceMailPassword8);
        keywordActions.Add("1", AddToVoiceMailPassword1);
        keywordActions.Add("8 1", AddToVoiceMailPassword8);
        keywordActions.Add("7 5", AddToVoiceMailPassword75);


        keywordRecognizer = new KeywordRecognizer(keywordActions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += OnKeywordsRecognized;
        keywordRecognizer.Start();
    }


    private void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
    {
        keywordActions[args.text].Invoke();
    }


    private void OpenDoorLvl3()
    {
        secretDoor.transform.position = new Vector3(-1.01F, 3.1f, -100f);
        Player.SetActive(true);
        
    }

    private void AddToVoiceMailPassword7()
    {
        UserVoiceMailPassWord = UserVoiceMailPassWord + "7";
        lenghtOfCurrentTry = lenghtOfCurrentTry + 1;
        if (lenghtOfCurrentTry == CurrentPasswordLenght)
        {
            checkPassWord();
        }   
    }
    private void AddToVoiceMailPassword75()
    {
        UserVoiceMailPassWord = UserVoiceMailPassWord + "75";
        lenghtOfCurrentTry = lenghtOfCurrentTry + 2;
        if (lenghtOfCurrentTry == CurrentPasswordLenght)
        {
            checkPassWord();
        }
    }
    private void AddToVoiceMailPassword5()
    {
        UserVoiceMailPassWord = UserVoiceMailPassWord + "5";
        lenghtOfCurrentTry = lenghtOfCurrentTry + 1;
        if (lenghtOfCurrentTry == CurrentPasswordLenght)
        {
            checkPassWord();
        }
    }
    private void AddToVoiceMailPassword8()
    {
        UserVoiceMailPassWord = UserVoiceMailPassWord + "8";
        lenghtOfCurrentTry = lenghtOfCurrentTry + 1;
        if (lenghtOfCurrentTry == CurrentPasswordLenght)
        {
            checkPassWord();
        }
    }
    private void AddToVoiceMailPassword1()
    {
        UserVoiceMailPassWord = UserVoiceMailPassWord + "1";
        lenghtOfCurrentTry = lenghtOfCurrentTry + 1;
        if (lenghtOfCurrentTry == CurrentPasswordLenght)
        {
            checkPassWord();
        }
    }
    private void AddToVoiceMailPassword81()
    {
        UserVoiceMailPassWord = UserVoiceMailPassWord + "81";
        lenghtOfCurrentTry = lenghtOfCurrentTry + 2;
        if (lenghtOfCurrentTry == CurrentPasswordLenght)
        {
            checkPassWord();
        }
    }

    private void checkPassWord()
    {
        if (UserVoiceMailPassWord == VoiceMailPassword)
        {
            FindObjectOfType<Phone>().ReadMessage();
        }
        else
        {
            lenghtOfCurrentTry = 0;
            UserVoiceMailPassWord = "";
            FindObjectOfType<AudioManager>().Play("PhoneError");
        }
    }
}
