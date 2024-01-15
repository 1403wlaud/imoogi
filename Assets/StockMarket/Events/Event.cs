using System;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "Event/Event")]
public class Event : ScriptableObject
{
    [Header("Global")]
    public DateTime startDate;
    public DateTime endDate;
    public Sprite headerSprite;
    public string header;
    [Multiline] public string description;

    public virtual void End(Game game) { }
    public virtual void Act(Game game) { }
}
