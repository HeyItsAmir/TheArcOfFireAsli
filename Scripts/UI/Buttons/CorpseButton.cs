using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CorpseButton : MonoBehaviour
{
    [SerializeField] GameObject player;

    [SerializeField] GameObject playerObjectDetectionSystem;

    void Update()
    {
        if(player.GetComponent<PlayerCarryCorpse>().corpse == null)
        {
            if(playerObjectDetectionSystem.GetComponent<ObjectDetectionSystem>().touchedObject != null && playerObjectDetectionSystem.GetComponent<ObjectDetectionSystem>().touchedObject.tag == "Corpse")
            {
                GetComponent<UnityEngine.UI.Image>().enabled = true;
            }
            else
            {
                GetComponent<UnityEngine.UI.Image>().enabled = false;
            }
        }
        else
        {
            GetComponent<UnityEngine.UI.Image>().enabled = true;
        }
    }

    public void CorpseButtonClicked()
    {
        if(player.GetComponent<PlayerCarryCorpse>().corpse == null)
        {
            if(playerObjectDetectionSystem.GetComponent<ObjectDetectionSystem>().touchedObject.tag == "Corpse")
            {
                player.GetComponent<PlayerCarryCorpse>().corpse = playerObjectDetectionSystem.GetComponent<ObjectDetectionSystem>().touchedObject;
            }
        }
        else
        {
            player.GetComponent<PlayerCarryCorpse>().DropCorpse();
        }
    }
}
