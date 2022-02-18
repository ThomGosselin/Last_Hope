using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;

public class ReconnaissanceVocalLVL3 : MonoBehaviour
{

    private Dictionary<string, Action> keywordActions = new Dictionary<string, Action>();
    private KeywordRecognizer keywordRecognizer;
    void Start()
    {
        keywordActions.Add("dernier espoir", OpenDoorLvl3);
        keywordActions.Add("last hope", OpenDoorLvl3);

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
        Debug.Log("Test");
    }

}
