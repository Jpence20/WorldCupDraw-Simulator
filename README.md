# WorldCupDraw-Simulator
The purpose of this program is to simulate a world cup draw. It follows the same format as the previous world cups as inspiration. 
The nations used are the ones that will particpate in the 2022 world cup. 

The way the draw works in real life. The program will end with 8 groups of 4 each with different nations in them. 

The 32 nations that qualified for the world cup was divided into 4 pots of 8. Their placement in the pots was based on FIFA Rankings. With the highest being put in pot 1 
and the lowest in pot 4. 
From there they are randomly drawned into different groups starting with pot 1and will draw and place all the teams from pot 1, until all teams have been placed in a group.
From there the three remaing pot would be drawn from and placed into groups.

So after pot 1, pot 2 would start getting placed. As they are drawn from the pots they are placed into groups starting from A.
So for example, the first team drawn from pot 2 would go into Group A, then the second team drawn from pot 2 would go into group B, and so on.
Along with this they would have what position in the group they would be in. For example if a team from pot 2 was placed into group A they would then they would drawn to see
if they are in A2,A3,or A4(A1 is always taken up from the team in pot 1). This is important for determining when teams will play each other.
This process will go on until all teams from all the pots are placed. 

The tricky part is that nations from the same region of the world can not end up in the same group, with execption being a group can have two teams from europe. 
If this happens you would move the team that got drawn to the next group. For example if a team can't go into Group A they would be put in Group B, and if they can't be put in 
Group you would go down the groups until you found an elgible group.

After all that you have the groups for the world cup. This video gives a good job at showing how the draw works.
https://www.youtube.com/watch?v=jDkn83FwioA


What I have done.
At the moment I have it setup to draw one team from each pot and put them in 8 different groups.

What I still need to figure out
1)How to make sure I don't get repeat nations, I haven't figure out how to stop drawing a nation once its already been picked.
2)How to then place them based on group postion. So, if a team will be placed in spot 2-4 of their group. (spot 1 is always taken up by the first team drawn into a group.
3) how to prevent a group from having too many countries from the same region. with the exception being a group can have two european countries.
