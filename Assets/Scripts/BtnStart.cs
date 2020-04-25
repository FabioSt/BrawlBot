using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnStart : MonoBehaviour
{
	public Button startBtn;

	void Start()
	{
		Button btn = startBtn.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
        StartCoroutine(ButtonDelay());
        
	}


    IEnumerator ButtonDelay()
    {
        yield return new WaitForSeconds(1f);

        // This line will be executed after x seconds passed
        SceneManager.LoadScene("Arena");
    }

}
