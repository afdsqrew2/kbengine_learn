using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoginCanvas : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField_1;
    [SerializeField] private TMP_InputField _inputField_2;

    [SerializeField] private Button _login_Button;

    // Start is called before the first frame update
    void Start()
    {
        _login_Button.onClick.AddListener(delegate
        {
            KBEngine.Event.fireIn(KBEngine.EventInTypes.login, new object[]
            {
                _inputField_1.text, _inputField_2.text, System.Text.Encoding.UTF8.GetBytes("hello!")
            });
        });
    }
}