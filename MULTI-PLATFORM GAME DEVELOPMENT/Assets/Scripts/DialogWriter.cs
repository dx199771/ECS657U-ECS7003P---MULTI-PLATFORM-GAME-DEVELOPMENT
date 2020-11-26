using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This class is for writing the dialog text to achieve a typing effect

public class DialogWriter : MonoBehaviour
{
    //multiple single text writers
    private List<DialogWriterSingle> dialogWriterSingleList;

    private void Awake()
    {
        dialogWriterSingleList = new List<DialogWriterSingle>();

    }

    //add a new text writer to text writer list
    public void AddWriter(Text uiText, string textToWrite, float timePerCharacter, bool invisibleChar, bool removeWriterBeforeAdd)
    {
        if (removeWriterBeforeAdd) //if current dialogue message hasnt done and click continue, remove current message and display next one
        {
            RemoveWriter(uiText);
        }
        dialogWriterSingleList.Add(new DialogWriterSingle(uiText, textToWrite, timePerCharacter, invisibleChar));

    }
    //double clike may destroy the dialog text
    //this is checking whether current display is uiText, if not remove
    private void RemoveWriter(Text uiText)
    {
        for (int i = 0; i < dialogWriterSingleList.Count; i++)
        {
            if (dialogWriterSingleList[i].GetUIText()==uiText)
            {
                dialogWriterSingleList.RemoveAt(i);
            }
        }
    }

    //update each frame
    private void Update()
    {
        //update each text writter
        for (int i = 0; i < dialogWriterSingleList.Count; i++)
        {
            bool destroyInstance = dialogWriterSingleList[i].Update();
            if (destroyInstance)
            {
                //remove from list when one analog text complete
                dialogWriterSingleList.RemoveAt(i);
                i--;
            }
        }
    }
    //single textWriter instance
    public class DialogWriterSingle
    {

        private Text uiText;
        private string textToWrite;
        private int characterIndex;
        private float timePerCharacter; //gap time between input of each character
        private float timer;
        private bool invisibleChar;

        public DialogWriterSingle(Text uiText, string textToWrite, float timePerCharacter, bool invisibleChar)
        {
            //assign each parameter
            this.uiText = uiText;
            this.textToWrite = textToWrite;
            this.timePerCharacter = timePerCharacter;
            this.invisibleChar = invisibleChar;
            characterIndex = 0;
        }
        //return true when complete
        public bool Update()
        {     
            //gap between each character
            timer -= Time.deltaTime;
            while (timer <= 0f)
            {
                //Display next character
                timer += timePerCharacter;
                //after each character, add character index
                characterIndex++;
                string text = textToWrite.Substring(0, characterIndex);
                //each character stay in final position
                //easy to read for player
                if (invisibleChar)
                {
                    text += "<color=#00000000>" + textToWrite.Substring(characterIndex) + "</color>";
                }
                uiText.text = text;
                //if typing done, display entire string
                if (characterIndex >= textToWrite.Length)
                    return true;

            }
            // not complete
            return false;
        }
        //get ui text content
        public Text GetUIText()
        {
            return uiText;
        }
    }
}
