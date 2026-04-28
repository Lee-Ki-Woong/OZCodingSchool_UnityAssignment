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


    // [Button Event] ========================================
    #region [Button Event]

    #endregion
}
