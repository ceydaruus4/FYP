using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CommandButton : MonoBehaviour
{
    [Multiline(10)]
    [SerializeField] private string commandText;
    [SerializeField] private TextMeshProUGUI commandTextMesh;

    public void OnDisplayCommandText()
    {
        commandTextMesh.SetText(commandText);
    }

    private void OnDisable()
    {
        commandTextMesh.SetText("");
    }





}
