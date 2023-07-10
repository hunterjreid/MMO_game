using UnityEngine;
using UnityEngine.UI;

public class MaterialChanger : MonoBehaviour
{
    public Dropdown dropdown;
    public Renderer objectRenderer;
    public Material[] materials;

    public Material mercuryMaterial;
    public Material venusMaterial;
    public Material earthMaterial;

    void Start()
    {
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    void OnDropdownValueChanged(int index)
    {
        if (index >= 0 && index < materials.Length)
        {
            switch (index)
            {
                case 0:
                    objectRenderer.material = mercuryMaterial;
                    break;
                case 1:
                    objectRenderer.material = venusMaterial;
                    break;
                case 2:
                    objectRenderer.material = earthMaterial;
                    break;
                    // ... and so on for other cases
            }
        }
    }
}
