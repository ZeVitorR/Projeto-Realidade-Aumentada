using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()//ela é iniciado uma vez no codigo ao iniciar
    {
        Debug.Log("Olá Mundo");
    }

    // Update is called once per frame
    void Update()//durante a execução da aplicação será executado
    {
        // Debug.Log("Olá Mundo repetido");
    }

    public void BtnLoginManage()
    {
        Debug.Log("Cliquei no botão");
    }
}
