using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RestartButtonTween : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Tween shakeAni = default;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("���콺 �÷��ξ���.");
        if (shakeAni == null || shakeAni == default)
        {
            shakeAni = transform.DOShakeScale(0.5f, 1, 10, 90, true, ShakeRandomnessMode.Harmonic).SetAutoKill();
            shakeAni.onKill += () => DisposeShake();
            return;
        }

        Debug.Log("ShakeAni�� ��������ʴ�.");
        

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = Vector3.one;
        //if (shakeAni.IsComplete())
        //{
        //    shakeAni = default;
        //}

    }
    
    //! Tween�� kill�ɶ� shakeAni ������ ����ִ� �Լ�
    private void DisposeShake()
    {
        transform.localScale = Vector3.one;

        shakeAni = default;
    }

}
