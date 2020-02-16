using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogues : MonoBehaviour
{
    [CreateAssetMenu(fileName = "New Dialogues", menuName ="Dialogues")]
    public class DialogueData : Dialogue { }
    [System.Serializable]
    public class Dialogue : ScriptableObject
    {
        public int npcID;
        public string npcName;
        public Message[] messages;
    }

    [System.Serializable]
    public class Message
    {
        public string text;
        public Response[] responses;
    }

    [System.Serializable]
    public class Response
    {
        public int next;
        public string reply;
        public string prereq;
        public string trigger;

    }
    
}