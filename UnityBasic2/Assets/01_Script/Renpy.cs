using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Renpy : MonoBehaviour
{
    [SerializeField] Image img_BG;
    [SerializeField] Image[] img_Character;

    [SerializeField] TextMeshProUGUI txt_Name;
    [SerializeField] TextMeshProUGUI txt_NameTitle;
    [SerializeField] TextMeshProUGUI txt_Dialogue;

    int dialogueNumber = 1001;

    private void Start()
    {
        Refresh();
    }

    public void OnClickNext()
    {
        dialogueNumber++;
        Refresh();
    }

    void Refresh()
    {
        txt_Name.text = SData.GetCharacterData((SData.GetDialogueData(dialogueNumber).Characterid)).Name;
        txt_NameTitle.text = SData.GetCharacterData((SData.GetDialogueData(dialogueNumber).Characterid)).Nametitle;
        txt_Dialogue.text = SData.GetDialogueData(dialogueNumber).Dialogue;

        img_BG.sprite = Resources.Load<Sprite>("Img/Renpy/" + SData.GetDialogueData(dialogueNumber).Bgimage);
        for (int i = 0; i < img_Character.Length; i++)
        {
            img_Character[i].gameObject.SetActive(false); // 모두 비활성화
        }
        for (int j = 0; j < img_Character.Length; j++)
        {
            img_Character[j].sprite = Resources.Load<Sprite>("Img/Renpy/" + SData.GetCharacterData(SData.GetDialogueData(dialogueNumber).Characterid).Image);
            img_Character[j].gameObject.SetActive(true);
        }
    }
}
