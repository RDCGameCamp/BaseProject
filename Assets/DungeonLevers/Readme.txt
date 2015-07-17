/*
README

Dungeon Levers
Lylek Games

Thank you for purchasing this asset!

Scripts and prefabs are already included for easy use. Demo scene provided.

To activate objects using the levers, we added an activation system.
The activation sytem is based on three separate scripts. The activation script, to detect
interactable objects; the interaction script, to relay activation to multiple objects and
scripts; and the action script, the script that actually moves (or what ever you want to
happen to) the object.

ACTIVATION-SCRIPT:
You can find the ActivationScript in the Scripts folder. Apply this script to your Main Camera.
This script is responsible for activating objects. In game, look at the object to be activated
and press the Left-Mouse-Button. An ActivationSctiptTop is also included for top-down view
games. Simply click on the object itself, instead of looking at it.

All objects you wish to activate must be taged as "Interact" and contain an Interaction Script.

INTERACTION-SCRIPT:
This script acts as a bridge between the ActivationScript and the actual action we want to happen.
This script has two variables, myObject, and myScript. myObject is an array that holds all the
objects you want activated. You can add as many objects as you want. myScript is also an array, but
in this case, requires a string (or text). This string should be the name of the scripts that you want
to activate, and should correspond directly with myObject.

For example: If we want to open a door... Player looks at lever, and presses Left-Mouse-Button. The
ActivationScript notices that the lever is taged as "Interact", and also contains an InteractionScript.
In the InteractionScript, the two myObjects we should have, would be the lever itself, and the door
we want to open. In corelation with these objects, we may want to have "AnimateSwitch", and "OpenDoor"
as our myScripts. AnimateSwitch and OpenDoor would refer to two other separate action scripts, made
specifically for animating a switch, and opening a door.

These scripts should be attached to the lever, and the door. The InteractionScript then Invokes the name
of the myScripts. These Invokes are functions called inside the InteractionScript. By doing this we can tell
all the objects we want, to run whatever scripts they have.

Know that for all additional actions you require, you must aquire or write your own scripts, and also wright a
function to Invoke, inside the InteractionScript itself. This function may consist of a single line of code:

function ActivateYOUR-SCRIPT-NAME() {
	obj.GetComponent(YOUR-SCRIPT-NAME).YOUR-SCRIPT'S-FUNCTION();
}

More documentation provided in the InteractionScript.
For a better understanding of the Activation System, please reference
the InteractionScript, its functions, and the MiscScripts provided.

If you need any help, please contact:
Email - support@lylekgames.com

Thank you.

*******************************************************************************************

Website
http://www.lylekgames.com/

Email
support@lylekgames.com
*/