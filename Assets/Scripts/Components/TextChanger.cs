using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;
    [SerializeField] private ComponentAnimationHandler componentAnimationHandler;
    [SerializeField] private string text1;
    [SerializeField] private string text2;

    public void ChangeText()
    {
        if(componentAnimationHandler.AnimationStateTypeValue == AnimationStateType.FIRST)
        {
            textComponent.text = text2;
        }
        else if (componentAnimationHandler.AnimationStateTypeValue == AnimationStateType.SECOND)
        {
            textComponent.text = text1;
        }
    }
}
