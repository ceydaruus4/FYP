using System;
using UnityEngine;

public class Events : MonoBehaviour
{
    [SerializeField] private GameEvent EnableComponent;
    [SerializeField] private GameEvent DisableComponent;
    public Action<int> onToggleComponentAnimation = delegate { };
    private static Events instance;



    public static Events Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Events>();
            }
            return instance;

        }
    }



    public void OnEnableComponentEvent()
    {
        EnableComponent.Raise();
    }

    public void OnDisableComponentEvent()
    {
        DisableComponent.Raise();
    }

    public void ToggleComponentAnimation(int id)
    {
        onToggleComponentAnimation.Invoke(id);
    }
}
