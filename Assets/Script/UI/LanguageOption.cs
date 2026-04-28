using UnityEngine;
using UnityEngine.UI;

public class LanguageOption : BaseExitUI
{
    // [SerializeField] ========================================
    #region [SerializeField]

    [SerializeField] private Button LanguageOptionKorBtn;
    [SerializeField] private Button LanguageOptionEngBtn;
    [SerializeField] private Button LanguageOptionChnBtn;
    [SerializeField] private Button LanguageOptionJpnBtn;

    #endregion


    // [Life Cycle] ========================================
    #region [Life Cycle]

    protected override void Start()
    {
        base.Start();

        LanguageOptionKorBtn = this.transform.Find("Menu/LanguageOption_KorBtn").GetComponent<Button>();
        LanguageOptionEngBtn = this.transform.Find("Menu/LanguageOption_EngBtn").GetComponent<Button>();
        LanguageOptionChnBtn = this.transform.Find("Menu/LanguageOption_ChnBtn").GetComponent<Button>();
        LanguageOptionJpnBtn = this.transform.Find("Menu/LanguageOption_JpnBtn").GetComponent<Button>();

        //LanguageOptionKorBtn.onClick.AddListener(OnClickLanguageKor);
        //LanguageOptionEngBtn.onClick.AddListener(OnClickLanguageEng);
        //LanguageOptionChnBtn.onClick.AddListener(OnClickLanguageChn);
        //LanguageOptionJpnBtn.onClick.AddListener(OnClickLanguageJpn);
    }

    #endregion


    // [Button Event] ========================================
    #region [Button Event]

    //private void OnClickLanguageKor()
    //{
    //    UIManager.Instance.OpenUI(MenuType.LanguageKor);
    //}

    //private void OnClickLanguageEng()
    //{
    //    UIManager.Instance.OpenUI(MenuType.LanguageEng);
    //}

    //private void OnClickLanguageChn()
    //{
    //    UIManager.Instance.OpenUI(MenuType.LanguageChn);
    //}

    //private void OnClickLanguageJpn()
    //{
    //    UIManager.Instance.OpenUI(MenuType.LanguageJpn);
    //}

    #endregion
}
