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
        Debug.Log("마우스 올려두었다.");
        if (shakeAni == null || shakeAni == default)
        {
            shakeAni = transform.DOShakeScale(0.5f, 1, 10, 90, true, ShakeRandomnessMode.Harmonic).SetAutoKill();
            shakeAni.onKill += () => DisposeShake();
            return;
        }

        Debug.Log("ShakeAni가 비어있지않다.");
        

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = Vector3.one;
        //if (shakeAni.IsComplete())
        //{
        //    shakeAni = default;
        //}

    }
    
    //! Tween이 kill될때 shakeAni 변수를 비워주는 함수
    private void DisposeShake()
    {
        transform.localScale = Vector3.one;

        shakeAni = default;
    }

}
