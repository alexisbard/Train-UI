using TMPro;
using UnityEngine;

public class ButtonController : MonoBehaviour {
    [SerializeField] private ButtonData buttonData = default;
    [SerializeField] private TextMeshProUGUI textMeshPro = default;

    private void Start() {
        textMeshPro.text = buttonData.Text;
    }
}