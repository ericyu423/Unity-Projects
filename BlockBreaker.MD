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
  <img src="https://github.com/ericyu423/Unity-Projects/blob/master/pics/note6.png" width="500"/>
</p>


