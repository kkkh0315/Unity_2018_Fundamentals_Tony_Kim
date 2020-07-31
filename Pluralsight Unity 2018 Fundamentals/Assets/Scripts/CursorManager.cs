using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // for NavMeshSurface script to work

    /* How to manage cursors!
     * 1. Create Empty and name it "CursorManager".
     * 2. Write a script "CursorManager".
     * 3. To "CursorManager", add component "CursorManager(Script)".
     * 4. Apply custom pngs to the Texture2Ds in "CursorManager".
     * 5. Set the texture type of the pngs to Cursor.
     * 6. Add "clickableLayer" as a layer, and "Doorway", "Item" as a tag.
     * 7. Change the tags and layers of the primitives accordingly.
     */
public class CursorManager : MonoBehaviour
{
    // Identify what objects are clickable
    public LayerMask clickableLayer;

    // Swap cursors per object
    public Texture2D pointer;
    public Texture2D target;
    public Texture2D doorway;
    public Texture2D pickable;

    // For player control
    public EventVector3 OnClickEnvironment;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 50, clickableLayer.value))
        {
            bool door = false;
            bool item = false;
            bool npc = false;
            if (hit.collider.gameObject.tag == "Doorway")
            {
                Cursor.SetCursor(doorway, new Vector2(16, 16), CursorMode.Auto);
                door = true;
            }
            else if (hit.collider.gameObject.tag == "Item")
            {
                Cursor.SetCursor(pickable, new Vector2(16, 16), CursorMode.Auto);
                item = true;
            }
            else if (hit.collider.gameObject.tag == "NPC")
            {
                Cursor.SetCursor(target, new Vector2(16, 16), CursorMode.Auto);
                npc = true;
            }
            else
            {
                Cursor.SetCursor(pointer, new Vector2(16, 16), CursorMode.Auto);
            }

            // For player control
            if (Input.GetMouseButtonDown(0))
            {
                if (door)
                {
                    Transform transDoor = hit.collider.gameObject.transform; // save the trasform of the clicked object

                    OnClickEnvironment.Invoke(transDoor.position); // move to the transDoor.position
                    Debug.Log("DOOR");
                }
                else if (item)
                {
                    Transform transItem = hit.collider.gameObject.transform;

                    OnClickEnvironment.Invoke(transItem.position);
                    Debug.Log("ITEM");
                }
                else if (npc)
                {
                    Transform transItem = hit.collider.gameObject.transform;

                    OnClickEnvironment.Invoke(transItem.position);
                    Debug.Log("RUNAWAY!!");
                }
                else
                {
                    OnClickEnvironment.Invoke(hit.point);
                }
            }
        }
        else
        {
            Cursor.SetCursor(pointer, Vector2.zero, CursorMode.Auto);
        }
    }
}

/* Need to create a class variable that is goint to store vector3 in my event.
 * So, when I click a position in my world, that is going to be passed as a 
 * parameter.
 */
[System.Serializable]
public class EventVector3 : UnityEvent<Vector3> { }