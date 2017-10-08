Notes:

# Create Project (Make sub-folders)
<p align="center">
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note1.png" width="500"/>
</p>

create new project

create two folders keep file organzied

 - scenes  (_scene so is easier to tell the words apart)
 - sprites (icons can be made by Sketch or just download them)
 
 # Make A package (import/export)
 
 <p align="center">
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note2.png" width="500"/>
</p>


Open old project 

Export - select the files you need
Save package

Open Current Project

Imoprt - open package

all files will inside assets folder

# Get Fonts for labels


 <p align="center">
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note3.png" width="500"/>
</p>
https://www.dafont.com

download get get TTF file drag and drop to asset folder (make subfolder fonts to keep things clean)

command + click the text files and change all their fonts (ariel -> Blockt)
(adjust font size and text bounds it will not fit like before)

# Link Start to Next Scene Level_01 (no need for script change)

 <p align="center">
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note4.png" width="500"/>
</p>

"on click" to the new level scene

Add temp Game over button on Level_01 Scene to test game scene flow

"error message "level_01" couldn't be loaded

fix by adding scene to build settings

 <p align="center">
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note5.png" width="500"/>
</p>

 <p align="center">
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note6.png" width="500"/>
</p>


- new scene "Level_01" does NOT have a game managerobject create it or copy and paste

to create 
  GameObject -> Create Empty -> drag LevelManger scrppt to "add component" 
  
- now you can use it to link level_01 to another scene via levelManager

# Add Muisc object

http://freesound.org/

- drap the music file (in this case mp3) to asset folder

- create MusicPlayer (GameObject -> create Empty)
- click and drag into componenet (For some reason it didn't work so drag into the file hierachy it will attach itself)
- transform the MusicPlayer object so (0,0,0) adjust volume 

It will play now in the level_01 scene only for now

<p align="center">
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note7.png" width="500"/>
</p>


add component add a musicPlayer c# script so the music will keep playing when scene is changed
- GameObject.DontDestroyOnLoad(gameObject);
<p align="center">
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note8.png" width="500"/>
</p>

you can see debug information on the eft and see that you are creating a lot of music objects
<p align="center">
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note9.png" width="500"/>
</p>



- problem it will play twice so need to create a singleton for the music object

we need to create static variable (static is share globally same as in Swift) 
it can be access without initiating the object

<p align="center">
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note10.png" width="500"/>
</p>

so even if we have a music play instance in our other scene it will still destory itself

* problem with this is it doesn't replay the music 

# debugging (introduce some probblems and fix them)

<p align="center">
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note11.png" width="500"/>
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note12.png" width="500"/>
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note13.png" width="500"/>
</p>

copy paste musicplayer Object to another scene (it will get play twice breifly when the program transitions to level_01)

fix

<p align="center">
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note14.png" width="500"/>
</p>

place the checking code in awake solves the problem

# Useful link to review coconcepts learned so far

http://wiki.unity3d.com/index.php/Singleton
https://unity3d.com/learn/tutorials/projects/2d-roguelike-tutorial/writing-game-manager

# Z-Depth in 2D (just like other game engines)
adjust z for background than you can put all your sprits at z = 0

<p align="center">
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note15.png" width="500"/>
</p>


# Aspect ratio

all 3 ipad version pro/new/old have roughtly 1.3333 raito same as 800:600 

pixel per unit (100)

800 pixel map into 16 world units about 50 (pixel per world unit)

# problem with camera preview not showing up(solution: adjust layer)

<p align="center">
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note17.png" width="500"/>
</p>

