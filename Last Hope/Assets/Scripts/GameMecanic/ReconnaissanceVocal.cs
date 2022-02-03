using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;

public class ReconnaissanceVocal : MonoBehaviour
{

    private Dictionary<string, Action> keywordActions = new Dictionary<string, Action>();
    private KeywordRecognizer keywordRecognizer;

    public GameObject peinture;
    public GameObject player;
    public GameObject key3;
    // Start is called before the first frame update
    void Start()
    {

        keywordActions.Add("test", MiniGameLvl1);


        keywordRecognizer = new KeywordRecognizer(keywordActions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += OnKeywordsRecognized;
        keywordRecognizer.Start();
    }

    private void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
    {
        keywordActions[args.text].Invoke();
    }

    private void MiniGameLvl1()
    {
        key3.SetActive(true);
        player.SetActive(true);
        peinture.SetActive(false);
    }
}
