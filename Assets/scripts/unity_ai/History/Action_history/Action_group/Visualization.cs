using System.Collections;
using System.Collections.Generic;
using rvinowise.unity.ai.patterns;
using rvinowise.unity.extensions;
using UnityEngine;

namespace rvinowise.unity.ai.action {

public partial class Action_group:
MonoBehaviour
{
    public Vector2 action_offset = new Vector2(0,2);
    public Transform body;
    

    private void place_next_action(Action in_action) {
        
        in_action.transform.parent = this.transform;
        in_action.transform.localPosition = 
            action_offset * (actions.Count-1);
        
    }

    public void extend_to_accomodate_children() {
        body.localScale = Vector2.one + action_offset * (actions.Count-1);
        body.localPosition =
            action_offset * (actions.Count - 1) / 2;
    }
    
}
}