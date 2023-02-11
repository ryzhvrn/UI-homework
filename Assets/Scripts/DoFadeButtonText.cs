using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DoFadeButtonText : MonoBehaviour
{
    private Text _buttonText;

    private void Start()
    {
        _buttonText = GetComponent<Text>();
    }

    public void OnButtonClick()
    {
        _buttonText.DOFade(0, 3).SetLoops(-1, LoopType.Yoyo);
    }
}
