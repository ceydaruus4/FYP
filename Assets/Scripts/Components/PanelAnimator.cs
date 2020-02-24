using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAnimator : MonoBehaviour
{
    [SerializeField] private string enablePanelAnimationTriggerName;
    [SerializeField] private Animator animator;


    public void OnEnablePanelAnimationTrigger()
    {
        animator.SetTrigger(enablePanelAnimationTriggerName);
    }



}
