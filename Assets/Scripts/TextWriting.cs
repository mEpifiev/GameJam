using System.Collections;
using UnityEngine;
using TMPro;

public class TextWriting : MonoBehaviour
{
    [SerializeField] private TMP_Text _textArea;
    [SerializeField] private string _textDialog;

    private string _text;

    private void Start()
    {
        _textArea.text = null;
        StartCoroutine(TextAnimation());
    }

    private IEnumerator TextAnimation()
    {
        foreach (var ABC in _textDialog)
        {
            _textArea.text += ABC;
            _text = ABC.ToString();

            if (_text == (".").ToString()
             || _text == (",").ToString()
             || _text == ("!").ToString()
             || _text == ("?").ToString())
            {
                yield return new WaitForSeconds(0.5f);
            }
            else
            {
                yield return new WaitForSeconds(0.05f);
            }
        }
    }
}
