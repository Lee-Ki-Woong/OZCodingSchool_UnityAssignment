using UnityEngine;
using UnityEngine.UI;

public class BaseExitUI : MonoBehaviour
{
    // [SerializeField] ========================================
    #region [SerializeField]

    [SerializeField] protected Button ExitBtn;

    #endregion


    // [Life Cycle] ========================================
    #region [Life Cycle]

    protected virtual void Start()
    {
        ExitBtn = this.transform.Find("ExitBtn").GetComponent<Button>();

        ExitBtn.onClick.AddListener(OnClickExit);
    }

    #endregion


    // [Button Event] ========================================
    #region [Button Event]

    protected void OnClickExit()
    {
        UIManager.Instance.CloseLastUI();
    }

    #endregion
}
