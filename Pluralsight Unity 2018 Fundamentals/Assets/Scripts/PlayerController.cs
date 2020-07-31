using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    /* How to make a controllable character that moves to the point where we click.
     * 1. Download "NavMeshComponents" and "Gizmos" files from Unity Github.
     * 2. Add them in your project, "Assets" folder.
     * (Unity also has a navigation system. Try it next time)
     * 3. Add "Empty" and name it "NavMeshSurface".
     * 4. Add "NavMeshSurface" component to the created "NavMeshSurface".
     * 5. Create a new layer called "Player".
     * 6. In "NavMeshSurface", exclude "Player" layer so that it does not back
     * objects that are layered "Player".
     * 7. Of course, set your player character's layer as "Player".
     * 8. For clickable objects, add "NavMeshObstacle" and "NavMeshModifier"
     * components to them.
     * 9. Under "NavMeshModifer" of clickable objects, check "Ignore From Build"
     * in order to exclude them from building.
     * 10. Under "NaveMeshObstacle" of clickable objects, check "Curve" if you
     * don't want the player to try to move through the object. If you don't
     * check "Curve", the player will try to move through it although it won't work.
     * (For example, if you check "Curve" for a door object, the player can't go
     * through the door, but when the door vanishes, the player can now go through
     * the spot where the door was initially located.)
     * 11. For the player character, add "NaveMeshAgent" component to it.
     * 12. Now, create a script called "PlayerController", which is the one you are
     * looking at right now.
     * 13. Adjust the "CursorManger" script accordingly as well. (Done it for you).
     * 14. Under "CursorManager", add "OnClickEnvironment(Vector3)", drag and drop
     * your player object to the "object" box, and under function, look for 
     * "NavMeshAgent" and click "destination".
     * 15. Under your player character, adjust "NavMeshAgent" options such as speed,
     * angular speed, acceleration, etc. (Tutorial: from speed, [5, 800, 30, 0.5])
     * 16. If everything is set up, go to "NavMeshSurface" and click bake.
     */

    /* How to apply animation to the character (idle -> run)
     * 1. Make an Animator Controller in Unity. (Right-click, create, Animator Controller).
     * 2. Go into the Animator Controller. Create Blend Tree. (Right-click, create state, From New Blend Tree).
     * 3. Double click Blend Tree. Change the name and the parameter to 'speed' in the inspector.
     * 4. Create a float parameter on the left side of the screen and name it 'speed' as well.
     * 5. Add two motion fields. One should be the animation for idle, the other for run.
     * 6. In your PlayerController script, add private Animator variable 'anim'.
     * 7. In Awake func, initialize anim into 'GetComponent<Animator>()'.
     * 8. Create the Update func. Set the parameter 'speed' of the animator to the agent's velocity magnitude.
     * 9. Back to Unity, set the player character's Animator Controller to the one you just created.
     * 10. 
     */

    private Animator anim;
    private NavMeshAgent agent;

    // Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        anim.SetFloat("Speed", agent.velocity.magnitude);
    }
}


/* Extra!!!
 * How to make your character hold a weapon (or swap weapons).
 * 1. Make the weapon the child of the wrist joint of your character.
 * 2. Change the transform to make it look like the character is holding the weapon.
 */