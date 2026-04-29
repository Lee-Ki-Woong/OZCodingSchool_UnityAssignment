using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// [Enum] ========================================
#region Enum

public enum MenuType : short
{
    None = 0,
    Main = 1,
    Exit = 99,

    MainStart = 101,
    MainCollection = 102,
    MainOption = 103,
    MainExit = 104,

    SoundOption = 201,
    GameOption = 202,
    LanguageOption = 203,
    ETCOption = 204,

}

#endregion

public class UIManager : MonoBehaviour
{
    // [Field] ========================================
    #region Field
    
    public static UIManager Instance { get; private set; }
    private Dictionary<MenuType, GameObject> m_UIDicList = new();
    private HashSet<MenuType> m_checkUseUI = new();
    private Stack<(MenuType,GameObject)> m_UseUIList = new();

    #endregion


    // [SerializeField] ========================================
    #region [SerializeField]

    [SerializeField] private GameObject UIList;

    #endregion


    // [Life Cycle] ========================================
    #region Life Cycle

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        FirstStartUI();
    }

    #endregion


    // [ UI Open & Close ] ========================================
    #region UI Open & Close

    private void OpenUI(MenuType menuType, GameObject uiObject)
    {
        if (m_checkUseUI.Contains(menuType) == false)
        {
            m_UseUIList.Push((menuType, uiObject));
            uiObject.SetActive(true);
            m_checkUseUI.Add(menuType);
        }
    }

    public void CloseUI(MenuType menuType)
    {
        if (m_checkUseUI.Contains(menuType))
        {
            GameObject gameObj = m_UIDicList[menuType];
            gameObj.SetActive(false);
            m_checkUseUI.Remove(menuType);
        }
    }

    public void CloseLastUI()
    {
        while (m_UseUIList.Count > 0)
        {
            (MenuType menuType, GameObject gameObj) = m_UseUIList.Pop();

            if (m_checkUseUI.Contains(menuType))
            {
                gameObj.SetActive(false);
                m_checkUseUI.Remove(menuType);
                break;
            }
        }
    }
    public void OpenUI(MenuType menuType)
    {
        GameObject gameObj = CreateUI(menuType);

        if(gameObj != null)
        {
            OpenUI(menuType, gameObj);
        }
    }

    #endregion


    // [ Get UIData ] ========================================
    #region Get UIData

    private GameObject CreateUI(MenuType menuType)
    { 
        if(m_UIDicList.ContainsKey(menuType) == false)
        {
            string path = GetUIDataPath(menuType);

            GameObject loadGameObject = (GameObject)Resources.Load(path);

            if(loadGameObject != null)
            {
                GameObject gameObj = Instantiate(loadGameObject);
                gameObj.transform.SetParent(UIList.transform, false);
                m_UIDicList.Add(menuType, gameObj);
            }
        }

        return m_UIDicList[menuType];
    }

    private string GetUIDataPath(MenuType menuType)
    {
        string path = $"Prefabs/UI/{menuType}";

        return path;
    }

    private void FirstStartUI()
    {
        CreateUI(MenuType.Main);
    }

    #endregion

    // [Active ] ========================================

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
