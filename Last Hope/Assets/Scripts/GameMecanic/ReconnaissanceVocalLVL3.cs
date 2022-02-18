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
    [Header("Éléments de l'enigme 3")]
    public string VoiceMailPassword;
    public string UserVoiceMailPassWord;
    public int CurrentPasswordLenght;
    public int lenghtOfCurrentTry;
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

        keywordRecognizer = new KeywordRecognizer(keywordActions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += OnKeywordsRecognized;
        keywordRecognizer.Start();
    }


    private void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("Test");
        keywordActions[args.text].Invoke();
    }


    private void OpenDoorLvl3()
    {
        //code de deplacement de la porte
    }

    private void AddToVoiceMailPassword7()
    {
        UserVoiceMailPassWord = UserVoiceMailPassWord + "7";
        if (lenghtOfCurrentTry == CurrentPasswordLenght)
        {
            checkPassWord();
        }
        else
        {
            lenghtOfCurrentTry = lenghtOfCurrentTry + 1;  
        }
       
    }
    private void AddToVoiceMailPassword5()
    {
        UserVoiceMailPassWord = UserVoiceMailPassWord + "5";
        if (lenghtOfCurrentTry == CurrentPasswordLenght)
        {
            checkPassWord();
        }
        else
        {
            lenghtOfCurrentTry = lenghtOfCurrentTry + 1;
        }
    }
    private void AddToVoiceMailPassword8()
    {
        UserVoiceMailPassWord = UserVoiceMailPassWord + "8";
        if (lenghtOfCurrentTry == CurrentPasswordLenght)
        {
            checkPassWord();
        }
        else
        {
            lenghtOfCurrentTry = lenghtOfCurrentTry + 1;
        }
    }
    private void AddToVoiceMailPassword1()
    {
        UserVoiceMailPassWord = UserVoiceMailPassWord + "1";
        if (lenghtOfCurrentTry == CurrentPasswordLenght)
        {
            checkPassWord();
        }
        else
        {
            lenghtOfCurrentTry = lenghtOfCurrentTry + 1;
        }
    }

    private void checkPassWord()
    {
        if (UserVoiceMailPassWord == VoiceMailPassword)
        {
            //code pour ce la suite de l'enigme
        }
    }
}
