# Template Method
## Challenge Game: Racing game

In this challenge, it will be a racing game as an example. In the game, it will 
be possible to choose the difficulty of the races, between easy, normal and 
hard. However, the sequence of clues and the track sounds are the same; 
therefore, they are the invariants (default, because they don't change). But, 
depending on the chosen difficulty, it has variant characteristics, that is, 
different between one level and other.

It will have to define invariant steps of the game regardless of the difficulty 
mode chosen by the player (default) and set "placeholders" to variant features 
of the game that may change according to the selected difficulty mode.
