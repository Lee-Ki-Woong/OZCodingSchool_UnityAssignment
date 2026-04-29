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

        GetMainOptionSoundBtn();
        GetMainOptionGameOptionBtn();
        GetMainOptionLanguageBtn();
        GetMainOptionETCBtn();
    }


    #endregion


    // [Get Button] ========================================
    #region [Get Button]
    // [Get Button] ========================================

    private void GetMainOptionSoundBtn()
    {
        MainOptionSoundBtn = this.transform.Find("Menu/MainOption_SoundBtn").GetComponent<Button>();
        if(MainOptionSoundBtn != null)
        {
            MainOptionSoundBtn.onClick.AddListener(OnClickSound);
        }
    }

    private void GetMainOptionGameOptionBtn()
    {
        MainOptionGameOptionBtn = this.transform.Find("Menu/MainOption_GameOptionBtn").GetComponent<Button>();
        if(MainOptionGameOptionBtn != null)
        {
            MainOptionGameOptionBtn.onClick.AddListener(OnClickGameOption);
        }
    }

    private void GetMainOptionLanguageBtn()
    {
        MainOptionLanguageBtn = this.transform.Find("Menu/MainOption_LanguageBtn").GetComponent<Button>();
        if(MainOptionLanguageBtn != null)
        {
            MainOptionLanguageBtn.onClick.AddListener(OnClickLanguage);
        }
    }

    private void GetMainOptionETCBtn()
    {
        MainOptionETCBtn = this.transform.Find("Menu/MainOption_ETCBtn").GetComponent<Button>();
        if(MainOptionETCBtn != null)
        {
            MainOptionETCBtn.onClick.AddListener(OnClickETC);
        }
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
