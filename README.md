# Emoji Clicker Game

This C# Windows Forms Application is a simple clicker game where the objective is to click on emojis that appear on the screen within a limited time. The game has multiple difficulty levels, and the player's score increases with each successful click.

## Features

### Form1
- Takes the player's name as input.
- Validates if the name is entered before proceeding.
- Opens Form2, passing the player's name as a parameter.

### Form2
- Displays the player's name received from Form1.
- Generates emojis (PictureBoxes) at random locations on the form.
- Emojis are clickable, and clicking on them increases the player's score.
- The game has a countdown timer, and the player's score increases with each successful click.
- Difficulty levels are available, affecting the countdown time.
- The game ends when the timer reaches zero, and a game over message is displayed with the player's score.

## How to Play

1. Launch the application.
2. Enter your name in Form1.
3. Click on the "Start Game" button to proceed to Form2.
4. Choose a difficulty level (Easy, Medium, or Hard).
5. Click on the emojis that appear on the form to increase your score.
6. The game ends when the timer reaches zero, and your score is displayed.

## Dependencies
None

## Notes
- Closing Form2 will return you to Form1.
- Clicking the "Exit" button in either form will close the application.

Feel free to explore and modify the code for your own projects!
