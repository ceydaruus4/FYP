using UnityEngine;
using System;

public enum AnimationStateType
{
    FIRST, SECOND
}

public class ComponentAnimationHandler : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private Animator animator;
    [SerializeField] private string firstAnimationTriggerName;
    [SerializeField] private string secondAnimationTriggerName;
    [SerializeField] private AnimationStateType animationStateType;

    private void OnEnable()
    {
        Events.Instance.onToggleComponentAnimation += ToggleAnimation;
    }

    private void OnDisable()
    {
        Events.Instance.onToggleComponentAnimation -= ToggleAnimation;
    }

    private void OnDestroy()
    {
        Events.Instance.onToggleComponentAnimation -= ToggleAnimation;
    }

    public AnimationStateType AnimationStateTypeValue => animationStateType;

    public void ToggleAnimation(int newID)
    {
        if (id == newID)
        {
            if (animationStateType == AnimationStateType.FIRST)
            {
                animationStateType = AnimationStateType.SECOND;
                animator.SetTrigger(secondAnimationTriggerName);
            }
            else if (animationStateType == AnimationStateType.SECOND)
            {
                animationStateType = AnimationStateType.FIRST;
                animator.SetTrigger(firstAnimationTriggerName);
            }
        }
    }

}
