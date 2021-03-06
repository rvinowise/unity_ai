using System.Collections;
using System.Collections.Generic;
using rvinowise.unity.ai;
using rvinowise.unity.extensions;
using UnityEngine;
using TMPro;

namespace rvinowise.unity.ai.action {

public partial class Action_group:
MonoBehaviour
{
    public Vector2 action_offset = new Vector2(0,2);
    //public GameObject body;
    public SpriteRenderer sprite_renderer;
    public Mood_label mood_label;
    public TextMeshPro moment_label;

    private void place_next_action(Action in_action) {
        in_action.transform.parent = this.transform;
        in_action.transform.localPosition = 
            action_offset * (actions.Count-1);
    }

    public void extend_to_accomodate_children() {
        sprite_renderer.size += action_offset * (actions.Count-1);
        
    }
    
}
}