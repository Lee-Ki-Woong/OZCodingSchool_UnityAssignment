using UnityEngine;
using UnityEngine.UI;

public class ETCOption : BaseExitUI
{
    // [SerializeField] ========================================
    #region [SerializeField]

    [SerializeField] private Button ETCOptionResourceBtn;
    [SerializeField] private Button ETCOptionRedeemCodeBtn;
    [SerializeField] private Button ETCOptionCreditBtn;

    #endregion


    // [Life Cycle] ========================================
    #region [Life Cycle]

    protected override void Start()
    {
        base.Start();

        ETCOptionResourceBtn = this.transform.Find("Menu/ETCOption_ResourceBtn").GetComponent<Button>();
        ETCOptionRedeemCodeBtn = this.transform.Find("Menu/ETCOption_RedeemCodeBtn").GetComponent<Button>();
        ETCOptionCreditBtn = this.transform.Find("Menu/ETCOption_CreditBtn").GetComponent<Button>();

        //ETCOptionResourceBtn.onClick.AddListener(OnClickResource);
        //ETCOptionRedeemCodeBtn.onClick.AddListener(OnClickRedeemCode);
        //ETCOptionCreditBtn.onClick.AddListener(OnClickCredit);
    }

    #endregion


    // [Button Event] ========================================
    #region [Button Event]

    //private void OnClickResource()
    //{
    //    UIManager.Instance.OpenUI(MenuType.Resource);
    //}

    //private void OnClickRedeemCode()
    //{
    //    UIManager.Instance.OpenUI(MenuType.RedeemCode);
    //}

    //private void OnClickCredit()
    //{
    //    UIManager.Instance.OpenUI(MenuType.Credit);
    //}

    #endregion
}
