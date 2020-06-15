I enjoyed the Runner game tutorial at  https://catlikecoding.com/unity/tutorials/runner/.

It was written for an older version of Unity, so some chamges were needed to make it work.  The main
problem was displaying text on the screen. I made a panel UI object and then put a text in each panel
to display the text for the game.

I have not been able to get setActive() to work yet, so I just make the background transparent and
set the text to "" when I wanted it to disappear.  I thin the main difference between the original tutorial
is the GUIManager script, so I am going to put that file here separately.
