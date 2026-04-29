using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    // [SerializeField] ========================================
    #region [SerializeField]

    [SerializeField] private Button MainStart;
    [SerializeField] private Button MainCollection;
    [SerializeField] private Button MainOption;
    [SerializeField] private Button MainExit;

    #endregion


    // [Life Cycle] ========================================
    #region [Life Cycle]

    private void Start()
    {
        GetMainStartBtn();
        GetMainCollectionBtn();
        GetMainOptionBtn();
        GetMainExitBtn();
    }

    #endregion


    // [Get Button] ========================================
    #region [Get Button]

    public void GetMainStartBtn()
    {
        MainStart = this.transform.Find("Menu/MainStartBtn").GetComponent<Button>();
        if (MainStart != null)
        {
            MainStart.onClick.AddListener(OnClickMainStart);
        }
    }

    public void GetMainCollectionBtn()
    {
        MainCollection = this.transform.Find("Menu/MainCollectionBtn").GetComponent<Button>();
        if (MainCollection != null)
        {
            MainCollection.onClick.AddListener(OnClickMainCollection);
        }
    }

    public void GetMainOptionBtn()
    {
        MainOption = this.transform.Find("Menu/MainOptionBtn").GetComponent<Button>();
        if (MainOption != null)
        {
            MainOption.onClick.AddListener(OnClickMainOption);
        }
    }

    public void GetMainExitBtn()
    {
        MainExit = this.transform.Find("Menu/MainExitBtn").GetComponent<Button>();
        if (MainExit != null)
        {
            MainExit.onClick.AddListener(OnClickMainExit);
        }
    }

    #endregion


    // [Button Event] ========================================
    #region [Button Event]

    private void OnClickMainStart()
    {
        UIManager.Instance.StartGame();
    }

    private void OnClickMainCollection()
    {
        UIManager.Instance.OpenUI(MenuType.MainCollection);
    }

    private void OnClickMainOption()
    {
        UIManager.Instance.OpenUI(MenuType.MainOption);
    }
    private void OnClickMainExit()
    {

    }

    #endregion
}
