# GDIM 31 Final: 3D
## Devlogs
### Milestone 1
I think the biggest problem for me was figuring out what the flow of the code was (as in what to code first, what I need to do, so basically planning). When I was coding for the Katamari and the Collectables, I was very confused on 
implementing the Collect method, as it was connected to the OnTriggerEnter method. I think the biggest issue I had was to figure out what I needed to call, how to do the trigger, and then debugging them. I didn't realize that I needed to actually assign the variables _rigidBody and _colliders first in the Start() method for the Collectables class, which I found out because of an error in the console. 
When I saw that it was a _colliders was an array, everything clicked for me. See, at the start, for my collectables I was using the ones in the models folder (no relevant components), not the prefabs folder (which mostly have 2 colliders in them). When I then used the correct ones, I noticed that they had two colliders, one of which had isTrigger enabled. 
This helped me realized that "Oh, I needed to use these all along, so my Katamari class's trigger actually work (instead of having one collider on the objects that would just make them fall into the ground if isTrigger was true), and then since there are multiple colliders, I need to foreach to disable all the ones in the array". 

### Milestone 2
TODO.

## Playtesting Reports
### Milestone 1
#### Report 1
TODO.

#### Report 2
TODO.

### Milestone 2
#### Report 1
TODO.

#### Report 2
TODO.

## Open-Source Assets
- [Ground textures and skybox](https://assetstore.unity.com/packages/3d/environments/landscapes/mountain-stylized-fantasy-environment-307488)
- [Quirky animals and animations](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235)
- [Building and RPG objects](https://assetstore.unity.com/packages/3d/environments/landscapes/rpg-poly-pack-lite-148410)
- [Dust cloud texture](https://assetstore.unity.com/packages/vfx/particles/fire-explosions/free-stylized-smoke-effects-pack-226406)
- [Sound effects](https://assetstore.unity.com/packages/audio/sound-fx/rpg-essentials-sound-effects-free-227708)
- [Jazz music](https://freesound.org/people/Mrthenoronha/sounds/518918/)