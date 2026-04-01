This is a short explanation of each class and how the program works. 

The program is a loop of levels, each level gets harder than the previous by addling floors. 

* 'Character' is the parent class for all characters, giving them unique attributes
* 'Player' is the class for the user, setting all of the stats that they need
* 'Goblin" is the enemy of player and this class inherits attributes from 'Character' to set information
* 'Skeleton' is the same as 'Goblin', only with different statistics

* 'Action' is the parent class for all actions taking place, which take damage and the name of the attack
* 'Attack' overrides the action and adds damage
* 'Magic' overrides the action and can either buff the next action, or heal the 'Character'
* 'Special' overrids the action and allows the 'Character' to deal more damage, and if they are 'Player', they also heal