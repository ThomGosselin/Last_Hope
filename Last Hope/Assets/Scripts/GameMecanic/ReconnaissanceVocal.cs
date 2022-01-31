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
    // Start is called before the first frame update
    void Start()
    {
        keywordActions.Add("Citrouille", Test);

        keywordRecognizer = new KeywordRecognizer(keywordActions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += OnKeywordsRecognized;
        keywordRecognizer.Start();
    }

    private void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("Allo");
        keywordActions[args.text].Invoke();
    }

    private void Test()
    {
        Debug.Log("Je suis un test");
    }
}
