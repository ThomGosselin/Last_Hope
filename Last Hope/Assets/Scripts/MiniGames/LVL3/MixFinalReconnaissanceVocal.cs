using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
public class MixFinalReconnaissanceVocal : MonoBehaviour
{
    [Header("Éléments pour la reconnaissance vocal")]
    private Dictionary<string, Action> keywordActions = new Dictionary<string, Action>();
    private KeywordRecognizer keywordRecognizer;
    [Header("Éléments essentiel pour la verification de la formule")]
    public int numberOfWords;
    public int UserNumberOfWords;
    public string MagicWord;
    public string UserMagicWord;

    private void Start()
    {
        keywordActions.Add("zinc", AddZincToMix);
        keywordActions.Add("chlore", AddChlorineToMix);
        keywordActions.Add("uranium", AddUraniumToMix);


        keywordRecognizer = new KeywordRecognizer(keywordActions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += OnKeywordsRecognized;
        keywordRecognizer.Start();
    }

    private void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
    {
        keywordActions[args.text].Invoke();
    }

    private void AddZincToMix()
    {
        UserNumberOfWords = UserNumberOfWords + 1;
        UserMagicWord = UserMagicWord + "zinc";
        if (UserNumberOfWords == numberOfWords)
        {
            CheckWin();
        }
    }
    private void AddChlorineToMix()
    {
        UserNumberOfWords = UserNumberOfWords + 1;
        UserMagicWord = UserMagicWord + "chlore";
        if (UserNumberOfWords == numberOfWords)
        {
            CheckWin();
        }
    }
    private void AddUraniumToMix()
    {
        UserNumberOfWords = UserNumberOfWords + 1;
        UserMagicWord = UserMagicWord + "uranium";
        if (UserNumberOfWords == numberOfWords)
        {
            CheckWin();
        }
    }
        private void CheckWin()
        {
           if(UserMagicWord == MagicWord)
           {
                Debug.Log("WIN");
           }
        }
    }