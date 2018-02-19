# Fog-of-War


Feature: Automatically create a layer of "cloud" objects above the ground. 
These "clouds' will dodge the position of the camera which represents player's viewpoint from a certain distance. 
After the camera leaves the area, the clouds will grow back in a short period of time.

Steps:

- Create "Cloud" object and make it to a prefab. 
This can be in any form such as a cube, sphere, or 2D sprite.

- Create an empty game object to generate "clouds" to fill the map. 
Expect those are too far away from the camera for the sake of saving computer's resources.

- Set the camera as the center, any "cloud" that is within a certain distance needs to shrink. 
When it gets small enough, hide the "Cloud" object.

- Check every "Cloud" object in the range of the camera. 
If it has not started to shrink, execute the action of shrinking.

- When the "cloud" objects are no longer in the range of the camera, and if it has not started to grow back, execute the action.

These are the basic concept of making fog of war.
