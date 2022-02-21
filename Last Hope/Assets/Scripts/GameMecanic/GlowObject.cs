using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowObject : MonoBehaviour
{
    private SpriteRenderer _renderer;
    private bool _isGlowing = false;
    private bool _glowUp = true;
    private float _blinkTimer = 0.5f;
    private float _glowValue = 1f;

    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {


        //Ajuste l'intensité du glow de matériel en clignotement
        if (_isGlowing)
        {
            _blinkTimer -= Time.deltaTime;
            if (_blinkTimer < 0f)
            {
                _blinkTimer = 0.5f;
                _glowUp = _glowUp ? false : true;
            }

            if (_glowUp)
            {
                _glowValue = 2f - _blinkTimer * 2f;
            }
            else
            {
                _glowValue = 1f + _blinkTimer * 2f;
            }
        }

        else
        {
            _glowValue -= Time.deltaTime;

            if (_glowValue < 1f)
            {
                _glowValue = 1f;
            }
        }

        _renderer.material.SetFloat("_intensity", _glowValue);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _isGlowing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _isGlowing = false;
        }
    }
}
