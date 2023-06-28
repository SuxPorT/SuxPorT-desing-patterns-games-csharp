# Bridge
## Challenge Game: Tetris

Tetris is a classic game where shapes come down the screen and the The goal is 
to stack them by fitting into each other.

Imagine that it would have to create the different shapes and colors for a game 
like that. Create an object and color for each possible way will not be a 
productive path. Let's imagine that it would have to create two shapes, each of 
which can be either orange, pink or green.

It would have that create six objects, which correspond to the amount of 
possibilities. However, we will use the Bridge pattern to reduce the amount of 
object creation to represent how possible shapes that will have color as 
reference, since each shape can have multiple cores. This reference will work as
a bridge (Bridge) between the shape and color classes. Then let's establish a 
link (here's a bridge) between form and color, so that whenever new colors were 
added, they will automatically be available to be combined and/or used by the 
shapes that will go down the game screen.
