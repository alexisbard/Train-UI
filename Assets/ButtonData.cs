using UnityEngine;

[CreateAssetMenu(menuName = "ButtonData")]
public class ButtonData : ScriptableObject {
    [SerializeField] private string text = default;
    public string Text => text;
}