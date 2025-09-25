# dMcCowan_FPS

The unreal first-person template already includes a shooting weapon base actor with firing capabilities and visible bullets that impact on coontact. Therefore my approach focused on being able to create my own version of that class. I created a new ShooterWeapon blueprint class that uses the pistol mesh but the rifle bullet firing rate and ammo.

The BP_FPSWeapon actor was created as a child of ShooterWeaponBase. In the editor the mesh was set to the premade mesh for the pistol. The animation, bullets, and HUD presets were all set to those for the rifle. I edited the DT_WeaponData Data Table to hold my new weapon (named Hyper Pistol). I added a duplicate of the weapon pickup from the shooter variant to the default level and set it to hold my new weapon.

# Controls
- Move with WASD
- Walk over the gun pickup to equip the weapon
- Aim and Shoot with the mouse
