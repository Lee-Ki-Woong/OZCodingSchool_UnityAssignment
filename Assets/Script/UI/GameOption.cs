using UnityEngine;
using UnityEngine.UI;

public class GameOption : BaseExitUI
{
    // [SerializeField] ========================================
    #region [SerializeField]

    [SerializeField] private Button GameOption_CombatClarityBtn;
    [SerializeField] private Button GameOption_ControlsBtn;
    [SerializeField] private Button GameOption_GraphicsBtn;

    #endregion


    // [Life Cycle] ========================================
    #region [Life Cycle]

    protected override void Start()
    {
        base.Start();

        GameOption_CombatClarityBtn = this.transform.Find("Menu/GameOption_CombatClarityBtn").GetComponent<Button>();
        GameOption_ControlsBtn = this.transform.Find("Menu/GameOption_ControlsBtn").GetComponent<Button>();
        GameOption_GraphicsBtn = this.transform.Find("Menu/GameOption_GraphicsBtn").GetComponent<Button>();

        //GameOption_CombatClarityBtn.onClick.AddListener(OnClickCombatClarity);
        //GameOption_ControlsBtn.onClick.AddListener(OnClickControls);
        //GameOption_GraphicsBtn.onClick.AddListener(OnClickGraphics);
    }

    #endregion


    // [Button Event] ========================================
    #region [Button Event]

    //private void OnClickCombatClarity()
    //{
    //    UIManager.Instance.OpenUI(MenuType.CombatClarity);
    //}

    //private void OnClickControls()
    //{
    //    UIManager.Instance.OpenUI(MenuType.Comtrol);
    //}

    //private void OnClickGraphics()
    //{
    //    UIManager.Instance.OpenUI(MenuType.Graphics);
    //}

    #endregion
}
