# dMcCowan_FPS

The unreal first-person template already includes a shooting weapon base actor with firing capabilities and visible bullets that impact on coontact. Therefore my approach focused on being able to create my own version of that class. I created a new ShooterWeapon blueprint class that uses the pistol mesh but the rifle bullet firing rate and ammo.

The BP_FPSWeapon actor was created as a child of ShooterWeaponBase. In the editor the mesh was set to the premade mesh for the pistol. The animation, bullets, and HUD presets were all set to those for the rifle. I edited the DT_WeaponData Data Table to hold my new weapon (named Hyper Pistol). I added a duplicate of the weapon pickup from the shooter variant to the default level and set it to hold my new weapon.

# Controls
- Move with WASD
- Walk over the gun pickup to equip the weapon
- Aim and Shoot with the mouse

I succcessfully brought the template AI controlled NPC over to the main level. In order for the AI to be able to move, I had to add a Nav mesh to the level. I faced some difficulties getting the AI to properly see the player. In order to fix this, I remove the first-person mesh from the NPC model and widened the view checking for the AI's sight.

 - The AI will pick random nearby positions to "search" by walking over to them.
 - If the AI partially sees the player or otherwise senses them it will "investigate" by facing and walking directly over to the location of the sighting.
 - If the AI finds the player, it will begin shooting. Its shots deal damage to the player.
 - Depending on the weapon equipped, the AI will stop shooting to reload.
 - When the AI is killed, all of its logic processes are stopped as well.

Waves will end when all enemies have been killed. The next wave will spawn 5 seconds after the last enemy died. Waves will have progressively more enemies. As the number of enemies spawn increases, their spawns will be staggered.
