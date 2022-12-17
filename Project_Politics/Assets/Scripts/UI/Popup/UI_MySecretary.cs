using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_MySecretary : UI_Popup
{
    public GameObject SecretaryInfo;
    [SerializeField] private int _maxCount = 4;

    enum Objects
    {
        CountText,
        OKButton,
        Content,
    }

    void Start()
    {
        Bind<GameObject>(typeof(Objects));
        BindEvent(GetObject((int)Objects.OKButton), (PointerEventData) => Managers.UI.ClosePopup(this));
        SetCount();
    }

    private void SetCount()
    {
        GetObject((int)Objects.CountText).GetComponent<Text>().text = $"{0}/{_maxCount}";
    }
}
