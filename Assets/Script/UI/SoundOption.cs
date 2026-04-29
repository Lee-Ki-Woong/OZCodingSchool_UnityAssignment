using UnityEngine;
using UnityEngine.UI;

public class SoundOption : BaseExitUI
{
    // [SerializeField] ========================================
    #region [SerializeField]

    [SerializeField] private Button SoundOptionBGMBtn;
    [SerializeField] private Button SoundOptionSFXBtn;
    [SerializeField] private Button SoundOptionAmbientBtn;

    #endregion


    // [Life Cycle] ========================================
    #region [Life Cycle]

    protected override void Start()
    {
        base.Start();

        SoundOptionBGMBtn = this.transform.Find("Menu/SoundOption_BGMBtn").GetComponent<Button>();
        SoundOptionSFXBtn = this.transform.Find("Menu/SoundOption_SFXBtn").GetComponent<Button>();
        SoundOptionAmbientBtn = this.transform.Find("Menu/SoundOption_AmbientBtn").GetComponent<Button>();
    }

    #endregion


    // [Get Button] ========================================
    #region [Get Button]

    //private void GetSoundOptionBGMBtn()
    //{
    //    SoundOptionBGMBtn = this.transform.Find("Menu/SoundOption_BGMBtn").GetComponent<Button>();
    //    if (SoundOptionBGMBtn != null)
    //    {
    //        SoundOptionBGMBtn.onClick.AddListener(OnClickSoundOptionBGM);
    //    }
    //}

    //private void GetSoundOptionSFXBtn()
    //{
    //    SoundOptionSFXBtn = this.transform.Find("Menu/SoundOption_SFXBtn").GetComponent<Button>();
    //    if (SoundOptionSFXBtn != null)
    //    {
    //        SoundOptionSFXBtn.onClick.AddListener(OnClickSoundOptionSFX);
    //    }
    //}

    //private void GetSoundOptionAmbientBtn()
    //{
    //    SoundOptionAmbientBtn = this.transform.Find("Menu/SoundOption_AmbientBtn").GetComponent<Button>();
    //    if (SoundOptionAmbientBtn != null)
    //    {
    //        SoundOptionAmbientBtn.onClick.AddListener(OnClickSoundOptionAmbient);
    //    }
    //}

    #endregion

    // [Button Event] ========================================
    #region [Button Event]

    //private void OnClickSoundOptionBGM()
    //{
    //    UIManager.Instance.OpenUI(MenuType.SoundOptionBGM);
    //}

    //private void OnClickSoundOptionSFX()
    //{
    //    UIManager.Instance.OpenUI(MenuType.SoundOptionSFX);
    //}

    //private void OnClickSoundOptionAmbient()
    //{
    //    UIManager.Instance.OpenUI(MenuType.SoundOptionAmbient);
    //}

    #endregion
}
