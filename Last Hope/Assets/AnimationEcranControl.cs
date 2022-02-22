using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEcranControl : MonoBehaviour
{
    [SerializeField] private Animator _AnimEcranControl;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _AnimEcranControl.SetBool("InTrigger", true);
        }

}
private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _AnimEcranControl.SetBool("InTrigger", false);
        }
    }
}
