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
        MainStart = this.transform.Find("Menu/MainStartBtn").GetComponent<Button>();
        MainCollection = this.transform.Find("Menu/MainCollectionBtn").GetComponent<Button>();
        MainOption = this.transform.Find("Menu/MainOptionBtn").GetComponent<Button>();
        MainExit = this.transform.Find("Menu/MainExitBtn").GetComponent<Button>();

        MainStart.onClick.AddListener(OnClickMainStart);
        MainCollection.onClick.AddListener(OnClickMainCollection);
        MainOption.onClick.AddListener(OnClickMainOption);
        MainExit.onClick.AddListener(OnClickMainExit);
    }

    #endregion


    // [Button Event] ========================================
    #region [Button Event]

    private void OnClickMainStart()
    {
        UIManager.Instance.OpenUI(MenuType.MainStart);
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
