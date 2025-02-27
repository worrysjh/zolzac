using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class WOSelBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WOSelBtnClick(){
        // 선택된 버튼 정보 가져오기
        string btnName = EventSystem.current.currentSelectedGameObject.name;
        GameObject woSeledBtn = GameObject.Find(btnName);
        Debug.Log(woSeledBtn.name + "버튼 선택됨.");

        // 게임 오브젝트 선언
        GameObject woNameTxt = GameObject.Find("WOnameTxt");
        GameObject woImg = GameObject.Find("WOImage");
        GameObject WOInfoTxt = GameObject.Find("WOInfoTxt");

        // 버튼의 운동 이름 가져오기...
        string woName = transform.Find("WOTxt").gameObject.GetComponent<TextMeshProUGUI>().text;

        // 해당 이미지 정보에 맞는 이미지 불러오기...
        Sprite woReimg = Resources.Load<Sprite>("Img/" + woName);
        if(woReimg == null){                                        // 맞는 이미지 정보 없을 경우...
            woReimg = Resources.Load<Sprite>("뉴진스 토끼");
        }
        
        // WOInfoPanel 정보 변경
        woNameTxt.GetComponent<TextMeshProUGUI>().text = woName;
        if(woName == "Squat"){
            WOInfoTxt.GetComponent<TextMeshProUGUI>().text = "발을 어깨너비로 벌린 후 허벅지가 수평이 될 때까지 여러 번 앉았다 일어나는 것으로, 엉덩이·허벅지 등 하체 근육 단련에 도움이 된다.";
        } else WOInfoTxt.GetComponent<TextMeshProUGUI>().text = woName + "에 대한 설명";
        woImg.GetComponent<Image>().sprite = woReimg;
    }
}
