using UnityEngine;

public class SData : SingletonBehabiour<SData>
{
    [SerializeField] Test testDatas; // DataTable의 데이터 탭 Name
    public static TestData[] TestData { get { return Instance.testDatas.dataArray; } } // 데이터 탭 Name + Data
    public static TestData GetTestData(int _id)
    {
        for (int i = 0; i < TestData.Length; i++)
            if (TestData[i].ID_I == _id)
                return TestData[i];
        return null;
    }

    [SerializeField] Dialogue dialogueDatas; // DataTable의 데이터 탭 Name
    public static DialogueData[] DialogueData { get { return Instance.dialogueDatas.dataArray; } } // 데이터 탭 Name + Data
    public static DialogueData GetDialogueData(int _id)
    {
        for (int i = 0; i < DialogueData.Length; i++)
        {
            if (DialogueData[i].ID == _id)
            {
                return DialogueData[i];
            }
        }
        return null;
    }

    [SerializeField] Character characterDatas; // DataTable의 데이터 탭 Name
    public static CharacterData[] CharacterData { get { return Instance.characterDatas.dataArray; } } // 데이터 탭 Name + Data
    public static CharacterData GetCharacterData(int _id)
    {
        for (int i = 0; i < CharacterData.Length; i++)
        {
            if (CharacterData[i].ID == _id)
            {
                return CharacterData[i];
            }
        }
        return null;
    }

}