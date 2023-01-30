using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class OnClick_Button : MonoBehaviour
{   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActiveUi(GameObject gameObject){
         gameObject.SetActive(true);
    }
    public void Quit(){
        Application.Quit();
        Debug.Log("나가졌습니다");
    }
    public void IsonBack(GameObject gameObject){
        gameObject.SetActive(false);
    }
  
    public void LoadScene(string string_){
        GFunc.LoadScene(string_);
    }
}
