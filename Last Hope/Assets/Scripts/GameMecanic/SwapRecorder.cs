using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapRecorder : MonoBehaviour
{
    public GameObject EmptyRecorder;
    public GameObject FullRecorder;

    public void Swap_Recorder()
    {
        EmptyRecorder.SetActive(false);
        FullRecorder.SetActive(true);
    }
}
