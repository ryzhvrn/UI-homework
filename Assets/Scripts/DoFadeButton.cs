using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DoFadeButton : MonoBehaviour
{
    private Image _buttonImage;

    private void Start()
    {
        _buttonImage = GetComponent<Image>();
    }

    public void OnButtonClick()
    {
        _buttonImage.DOFade(0, 3).SetLoops(-1, LoopType.Yoyo);
    }
}
