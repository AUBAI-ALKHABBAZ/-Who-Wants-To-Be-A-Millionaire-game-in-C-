# -Who-Wants-To-Be-A-Millionaire-game-in-C-
__________________________________________________________________________________
Objective of the Assignment
This assignment aims to develop a game based on "Who Wants to Be a Millionaire" using Graphical User Interface (GUI) in Object-Oriented Programming (OOP). The assignment focuses on:

    1-Building a clear program structure using Inheritance and Classes.
    2-Handling text files as a database for questions.
    3-Managing an interactive user interface with levels and lifelines (helps).

<img width="760" height="482" alt="Screenshot 2026-03-24 033924" src="https://github.com/user-attachments/assets/68ed5932-082d-479d-916e-894e97443a79" />

Problem Description
How the Game Works:
  The game consists of 15 levels to reach the million.
  At the start of the competition, questions are loaded from a text file.
  For the first question, the level is set and help options are reset.
  For each level, a random question is selected from 5 questions dedicated to that level.
  When displaying a question, the correct answer is mixed with three incorrect answers.
  After selecting an answer, a message appears indicating whether the answer is correct or incorrect, along with the amount of money earned.
  Then, either proceed to the next level or end the game.


Available Lifelines (Helps):
        50:50 – Remove two incorrect answers.
        Change Question – Display another question from the same level.
        Audience Poll – (Note: Mentioned but not detailed in original)
Questions File:
        You will be provided with a pre-prepared text file by the instructor.
        Format: Correct Answer + 6+ Incorrect Answers + 5 Questions per level
⚠️ Important: You are not allowed to modify the method of writing questions in the file.
Required Classes
1. QUESTIONBASE (Abstract Class)
  Contains:
        Question text
        Level number
        A constructor to validate logical input values
        Method IsCorrect(string answer): Returns a logical value to verify the answer's correctness
2. QUESTION (Inherited from QUESTIONBASE)
  Contains:
        Question text
        Level
        Correct answer
        Array of incorrect answers
        Constructor that receives all data
        Implements the IsCorrect method, returning TRUE if the answer is correct
3. GAMEMANAGER
  Contains:
    Attributes:
          A 2D array of size (5×15) to store questions
          A random number generator object
    Methods:
          LoadQuestions(string path) → Load questions from file
          GetRandomQuestion(int level) → Select a random question
          GetShuffledAnswers(Question q) → Shuffle the correct answer with incorrect ones
