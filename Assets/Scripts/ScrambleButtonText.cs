using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ScrambleButtonText : MonoBehaviour
{
    [SerializeField] private Text _buttonText;

    public void OnButtonClick()
    {
        _buttonText.DOText("�� � ���������", 3, true, ScrambleMode.Numerals);
        _buttonText.DOColor(Color.green, 3);
    }
}
