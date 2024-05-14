using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace fpfsimpledialoguesystem
{
    public class DialogueActivator : MonoBehaviour
    {
        [SerializeField]
        public GameObject dialoguePanel;
        [SerializeField]
        public bool destroyDialogueActivator;
        [SerializeField]
        public string tagPlayer = "Player";
        [SerializeField]
        string path;
        [SerializeField]
        List<Sprite> characterImages;
        [SerializeField]
        bool stopGame = false;
        private void OnTriggerEnter(Collider other)
        {
            if (other.transform.CompareTag(tagPlayer))
            {
                if (stopGame)
                {
                    Time.timeScale = 0f;
                }
                dialoguePanel.SetActive(true);
                dialoguePanel.GetComponent<SimpleDialogueSystem>().Path = path;
                dialoguePanel.GetComponent<SimpleDialogueSystem>().CharacterImages = characterImages;
                dialoguePanel.GetComponent<SimpleDialogueSystem>().StartDialogue();
                if (destroyDialogueActivator)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
