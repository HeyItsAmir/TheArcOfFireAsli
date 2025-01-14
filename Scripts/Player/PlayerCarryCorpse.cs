using UnityEngine;

public class PlayerCarryCorpse : MonoBehaviour
{
    public GameObject corpse;

    [SerializeField] Transform corpseCarryArea;

    [SerializeField] Transform corpseDropArea;

    void Update()
    {
        if(corpse != null)
        {
            corpse.GetComponent<Collider>().isTrigger = true;
            corpse.transform.position = corpseCarryArea.position;
        }
    }
    
    public void DropCorpse()
    {
        corpse.GetComponent<Collider>().isTrigger = false;
        corpse.transform.position = corpseDropArea.position;
        corpse = null;
    }
}
