using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class OnClick_Button : MonoBehaviour
{
    public GameObject Setting_UI = null;
    public GameObject Play_UI = null;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoPlay(){
        Play_UI.SetActive(true);

    }
    public void Quit(){
        Application.Quit();
        Debug.Log("나가졌습니다");
    }
    public void Setting(){
        Debug.Log(Setting_UI.activeInHierarchy);   
        Setting_UI.SetActive(true);
        
    }
    public void IsonBack(GameObject gameObject){
        gameObject.SetActive(false);
    }
    public void PlayBack(){
        Play_UI.SetActive(false);
    }
    public void Play(){
        SceneManager.LoadScene("Play");
    }
}
