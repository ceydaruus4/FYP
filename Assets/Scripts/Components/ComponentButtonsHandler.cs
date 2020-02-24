using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentButtonsHandler : MonoBehaviour
{
    public void EnableComponentEvent()
    {
        Events.Instance.OnEnableComponentEvent();
    }

    public void DisableComponentEvent()
    {
        Events.Instance.OnDisableComponentEvent();
    }




}


