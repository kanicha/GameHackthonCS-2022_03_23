using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    [SerializeField] Image _curor;
    [SerializeField] GameObject[] _titleText;
    [SerializeField] float _cursorLength = -500;
    private int _selectNum  =0;
    Vector2 vec = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        vec = _titleText[0].transform.position;
        vec += new Vector2(_cursorLength, 0);
        _curor.transform.position = vec;

        // X����������
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {

            _selectNum--;
            SelectText();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _selectNum++;
            SelectText();
        }


    }

    private void SelectText()
    {
        if (_selectNum >= _titleText.Length)
        {
            _selectNum = _titleText.Length - 1;
        }
        else if (_selectNum <= 0) 
        {
            _selectNum = 0;

        }


            vec = _titleText[_selectNum].transform.position;
        vec += new Vector2(_cursorLength, 0);
        _curor.transform.position = vec;

    }
}
