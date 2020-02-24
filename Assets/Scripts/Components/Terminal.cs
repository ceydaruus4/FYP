using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Terminal : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private GameObject contentPanel;
    [SerializeField] private TextMeshProUGUI codeText;
    [SerializeField] private TextMeshProUGUI helpCodeText;
    [SerializeField] private TextMeshProUGUI cpuCodeText;
    private List<string> folderNames = new List<string>();
    private List<GameObject> allCodeTexts = new List<GameObject>();
    [SerializeField] private string ipAddress = "192.168.1.1";

    [Header("Buttons")]
    [SerializeField] private Button cpuButton;
    [SerializeField] private Button helpButton;
    [SerializeField] private Button dirButton;
    [SerializeField] private Button ipconfigButton;
    [SerializeField] private Button clsButton;
    [SerializeField] private Button exitButton;

    private void Awake()
    {
        cpuButton.onClick.AddListener(delegate { DisplayCPUInfo(); });
        helpButton.onClick.AddListener(delegate { DisplayHelp(); });
        dirButton.onClick.AddListener(delegate { DisplayAllFolderNames(); });
        ipconfigButton.onClick.AddListener(delegate { DisplayIPAddress(); });
        clsButton.onClick.AddListener(delegate { ClearConsole(); });
        exitButton.onClick.AddListener(delegate { ExitConsole(); });
    }

    private void Start()
    {
        folderNames.Add("Animation");
        folderNames.Add("Materials");
        folderNames.Add("Models");
        folderNames.Add("Prefabs");
        folderNames.Add("Scenes");
        folderNames.Add("Scripts");
        folderNames.Add("Sprites");
        folderNames.Add("TextMeshPro");
    }

    private void DisplayCPUInfo()
    {
        // Spawn a text object inside the content panel
        GameObject codeTextToSpawn = Instantiate(cpuCodeText.gameObject, contentPanel.transform) as GameObject;

        // Then set the text of the text mesh pro to the folder name
        codeTextToSpawn.GetComponent<TextMeshProUGUI>().text = cpuCodeText.text;

        allCodeTexts.Add(codeTextToSpawn);
    }

    private void DisplayHelp()
    {
        // Spawn a text object inside the content panel
        GameObject codeTextToSpawn = Instantiate(helpCodeText.gameObject, contentPanel.transform) as GameObject;

        // Then set the text of the text mesh pro to the folder name
        codeTextToSpawn.GetComponent<TextMeshProUGUI>().text = helpCodeText.text;

        allCodeTexts.Add(codeTextToSpawn);
    }

    private void DisplayAllFolderNames()
    {
        // check if there are any folders
        if (folderNames.Count > 0)
        {
            // Spawn a text object inside the content panel
            GameObject codeTextToSpawn = Instantiate(codeText.gameObject, contentPanel.transform) as GameObject;
            RectTransform rt = codeTextToSpawn.GetComponent(typeof(RectTransform)) as RectTransform;

            // Loop through all the folder names
            for (int i = 0; i < folderNames.Count; i++)
            {
                // Then set the text of the text mesh pro to the folder name
                codeTextToSpawn.GetComponent<TextMeshProUGUI>().text += folderNames[i] + "\n";
            }

            // Set the vector of the rect transform
            rt.sizeDelta = new Vector2(rt.sizeDelta.x, 28f);

            allCodeTexts.Add(codeTextToSpawn);
        }
    }

    private void DisplayIPAddress()
    {
        // Spawn a text object inside the content panel
        GameObject codeTextToSpawn = Instantiate(codeText.gameObject, contentPanel.transform) as GameObject;

        // Then set the text of the text mesh pro to the folder name
        codeTextToSpawn.GetComponent<TextMeshProUGUI>().text = ipAddress;

        allCodeTexts.Add(codeTextToSpawn);
    }

    private void ClearConsole()
    {
        if (allCodeTexts.Count > 0)
        {
            for (int i = 0; i < allCodeTexts.Count; i++)
            {
                Destroy(allCodeTexts[i]);
                allCodeTexts.Remove(allCodeTexts[i]);
            }
        }
    }

    private void ExitConsole()
    {
        this.gameObject.SetActive(false);
    }


}
