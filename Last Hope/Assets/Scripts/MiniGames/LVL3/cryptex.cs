using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cryptex : MonoBehaviour
{
    [Header("Input Field")]
    public TMP_Text Letter1;
    public TMP_Text Letter2;
    public TMP_Text Letter3;
    public TMP_Text Letter4;
    [Header("Bouton pour changer la lettre")]
    public Button Up1;
    public Button Down1;
    public Button Up2;
    public Button Down2;
    public Button Up3;
    public Button Down3;
    public Button Up4;
    public Button Down4;
    [Header("Section pour Pour le changement des lettres du cryptex")]
    public string[] Alphabet = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    public int Index1 = 0;
    public int Index2 = 0;
    public int Index3 = 0;
    public int Index4 = 0;


    public void Index1Up()
    {
        Index1 = Index1 + 1;
        if (Index1 == Alphabet.Length)
        {
            Index1 = 0;
        }
        Letter1.text = Alphabet[Index1];
    }

    public void Index2Up()
    {
        Index2 = Index2 + 1;
        if (Index2 == Alphabet.Length)
        {
            Index2 = 0;
        }
        Letter2.text = Alphabet[Index2];
    }

    public void Index3Up()
    {
        Index3 = Index3 + 1;
        if (Index3 == Alphabet.Length)
        {
            Index3 = 0;
        }
        Letter3.text = Alphabet[Index3];
    }

    public void Index4Up()
    {
        Index4 = Index4 + 1;
        if (Index4 == Alphabet.Length)
        {
            Index4 = 0;
        }
        Letter4.text = Alphabet[Index4];
    }
    
    public void Index1Down()
    {
        if (Index1 == 0)
        {
            Index1 = Alphabet.Length;
        }
        Index1 = Index1 - 1;
        Letter1.text = Alphabet[Index1];
    }
    public void Index2Down()
    {
        if (Index2 == 0)
        {
            Index2 = Alphabet.Length;
        }
        Index2 = Index2 - 1;
        Letter2.text = Alphabet[Index2];
    }
    public void Index3Down()
    {
        if (Index3 == 0)
        {
            Index3 = Alphabet.Length;
        }
        Index3 = Index3 - 1;
        Letter3.text = Alphabet[Index3];
    }
    public void Index4Down()
    {
        if (Index4 == 0)
        {
            Index4 = Alphabet.Length;
        }
        Index4 = Index4 - 1;
        Letter4.text = Alphabet[Index4];
    }

}
