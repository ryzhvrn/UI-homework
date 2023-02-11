using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DoMoveButton : MonoBehaviour
{
    public void OnButtonClick()
    {
        transform.DOMove(new Vector2(3, 5),2);
    }
}
