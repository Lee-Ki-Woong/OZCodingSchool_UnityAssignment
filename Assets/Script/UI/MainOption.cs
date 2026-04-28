using UnityEngine;
using UnityEngine.UI;

public class MainOption : BaseExitUI
{
    // [SerializeField] ========================================
    #region [SerializeField]

    [SerializeField] private Button MainOptionSoundBtn;
    [SerializeField] private Button MainOptionGameOptionBtn;
    [SerializeField] private Button MainOptionLanguageBtn;
    [SerializeField] private Button MainOptionETCBtn;

    #endregion


    // [Life Cycle] ========================================
    #region [Life Cycle]

    protected override void Start()
    {
        base.Start();

        MainOptionSoundBtn = this.transform.Find("Menu/MainOption_SoundBtn").GetComponent<Button>();
        MainOptionGameOptionBtn = this.transform.Find("Menu/MainOption_GameOptionBtn").GetComponent<Button>();
        MainOptionLanguageBtn = this.transform.Find("Menu/MainOption_LanguageBtn").GetComponent<Button>();
        MainOptionETCBtn = this.transform.Find("Menu/MainOption_ETCBtn").GetComponent<Button>();

        MainOptionSoundBtn.onClick.AddListener(OnClickSound);
        MainOptionGameOptionBtn.onClick.AddListener(OnClickGameOption);
        MainOptionLanguageBtn.onClick.AddListener(OnClickLanguage);
        MainOptionETCBtn.onClick.AddListener(OnClickETC);
    }

    #endregion


    // [Button Event] ========================================
    #region [Button Event]

    private void OnClickSound()
    {
        UIManager.Instance.OpenUI(MenuType.SoundOption);
    }

    private void OnClickGameOption()
    {
        UIManager.Instance.OpenUI(MenuType.GameOption);
    }

    private void OnClickLanguage()
    {
        UIManager.Instance.OpenUI(MenuType.LanguageOption);
    }
    
    private void OnClickETC()
    {
        UIManager.Instance.OpenUI(MenuType.ETCOption);
    }

    #endregion
}
