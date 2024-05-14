using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace fpfsimpledialoguesystem
{
    public class SimpleDialogueSystem : MonoBehaviour
    {
        [SerializeField]
        Image dialogueUICharacterImage;
        [SerializeField]
        TextMeshProUGUI dialogueUICharacterName;
        [SerializeField]
        TextMeshProUGUI dialogueUIText;

        private string path;
        private List<Sprite> characterImages;

        private int dialoguePosition = 0;
        private int imagePosition = 0;

        string[] lines = null;

        public string Path { get => path; set => path = value; }
        public List<Sprite> CharacterImages { get => characterImages; set => characterImages = value; }

        public void StartDialogue()
        {
            dialoguePosition = 0;
            imagePosition = 0;
            TextAsset textFile = Resources.Load<TextAsset>(Path);
            string content = textFile.text;
            lines = content.Split("\n");
            //lines = File.ReadAllLines(Path);
            dialogueUICharacterName.text = lines[dialoguePosition];
            dialogueUICharacterImage.sprite = CharacterImages[dialoguePosition % 2];
            dialogueUIText.text = lines[dialoguePosition + 1];
            
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                NextLine();
            }
        }

        public void NextLine()
        {
            dialoguePosition += 2;
            imagePosition++;
            if (dialoguePosition >= lines.Length)
            {
                Time.timeScale = 1f;
                gameObject.SetActive(false);
                return;
            }
            else
            {
                dialogueUICharacterName.text = lines[dialoguePosition];
                dialogueUICharacterImage.sprite = CharacterImages[imagePosition % 2];
                dialogueUIText.text = lines[dialoguePosition + 1];
            }
        }
    }
}
