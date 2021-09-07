using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    // Start is called before the first frame update
    Button b;
    void Start()
    {
        b = GetComponent<Button>();
    }

    // Update is called once per frame
    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
}
