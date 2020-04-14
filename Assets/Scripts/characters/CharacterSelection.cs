using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;


public class CharacterSelection : MonoBehaviour {
    public GameObject[] SelectCharacter;

    public Button CharacterButtonA;
    public Button CharacterButtonB;
    public Button CharacterButtonC;

    public GameObject PlayWindow;
    public GameObject SettingWindow;


    // public Button CharacterSelectA;
    // public Button CharacterSelectB;
    // public Button CharacterSelectC;

    // Start is called before the first frame update
    void Start()
    {

        SettingWindow.SetActive(true);
        PlayWindow.SetActive(false);
        for (int i = 0; i < SelectCharacter.Length; i++) {
            // SelectCharacter[i].SetActive(false);
            SelectCharacter[i].SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        // CharacterSet();
    }
    public void CharacterSet(int index) {
        for (int i = 0; i < SelectCharacter.Length; i++) {
            SelectCharacter[i].SetActive(false);
        }
        SelectCharacter[index].SetActive(true);
        if(index == 0) {

        }
        else if (index == 1){

        }
        else if(index  == 2) {

        }
        

    }

    public void Selection() {
       PlayWindow.SetActive(true);
       SettingWindow.SetActive(false);

    }

}
