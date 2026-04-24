using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    public Transform _setStoneTransform;
    public Object BlackStoneObject;
    public Object WhiteStoneObject;
    private int _stoneNumber;
    Vector3 _setStone = new Vector3();
    public GameObject myChildWhiteStone;
    public GameObject myChildBlackStone;

    private void Awake()
    {
        BlackTurn();
    }

    // Update is called once per frame
    private void Update()
    {
        SetVector();
        GoRightOnUpdate();
        CreateBlackOnUpdate();
        CreateWhiteOnUpdate();
    }

    private void WhiteTurn()
    {
        myChildWhiteStone.SetActive(true);
        myChildBlackStone.SetActive(false);
    }

    private void BlackTurn()
    {
        myChildBlackStone.SetActive(true);
        myChildWhiteStone.SetActive(false);
    }

    private void GoRightOnUpdate()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            this.gameObject.transform.Translate(Vector3.right);
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            this.gameObject.transform.Translate(Vector3.back);
        }
        else if( Input.GetKeyDown(KeyCode.A))
        {
            this.gameObject.transform.Translate(Vector3.left);
        }
        else if(Input.GetKeyDown(KeyCode.W))
        {
            this.gameObject.transform.Translate(Vector3.forward);
        }
    }

    private void CreateBlackOnUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q) && myChildBlackStone.activeInHierarchy)
        {
            _setStone = SetVector();

            _stoneNumber++;
            var newStone = Instantiate(BlackStoneObject,_setStone, Quaternion.identity, _setStoneTransform);
            newStone.name = ($"Stone_{_stoneNumber}");
            WhiteTurn();
        }
    }

    private void CreateWhiteOnUpdate()
    {
        if(Input.GetKeyDown(KeyCode.E) && myChildWhiteStone.activeInHierarchy)
        {
            _setStone = SetVector();

            _stoneNumber++;
            var newStone = Instantiate(WhiteStoneObject, _setStone, Quaternion.identity, _setStoneTransform);
            newStone.name = ($"Stone_{_stoneNumber}");
            BlackTurn();
        }
    }

    private Vector3 SetVector()
    {
        var myVector = this.transform.position + Vector3.down * 4;

        return myVector;
    }
}
