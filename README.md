# 💰 Who Wants To Be A Millionaire? (Object-Oriented C# GUI Project)
[![C#](https://img.shields.io/badge/C%23-Language-blue.svg?logo=csharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-Core%2FFramework-purple.svg)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

A fully functional Graphical User Interface (GUI) implementation of the classic television game show **"Who Wants To Be A Millionaire?"**, engineered in C# following strict **Object-Oriented Programming (OOP)** principles and robust software architecture patterns.

---

## 📐 Academic Objective & Design Requirements

This project was developed to demonstrate advanced desktop software engineering skills, focusing on:

1. **Object-Oriented Inheritance & Polymorphism:** Implementing abstract base classes and derived classes for robust question modeling.
2. **Text File Database Parsing:** Efficiently parsing structured external text files to populate a dynamic multi-tiered question bank without altering source file formats.
3. **Interactive GUI & State Management:** Coordinating a 15-level prize progression structure, random shuffling algorithms, lifeline management, and real-time user feedback.

---

## 🏛️ Core Object-Oriented Architecture

The application is structured around a clean class hierarchy designed to separate data encapsulation from game logic and state control:

### 1. `QUESTIONBASE` (Abstract Base Class)

Serves as the foundation for all quiz inquiries, establishing baseline properties and contract enforcement:

* **Properties:** `QuestionText`, `LevelNumber`.
* **Constructor:** Validates logical input values and bounds.
* **Abstract/Virtual Method:** `IsCorrect(string answer)` — enforces answer verification logic across derived classes.

### 2. `QUESTION` (Inherited Class)

Extends `QUESTIONBASE` to manage specific question components and answer arrays:

* **Properties:** Correct answer string, array/list of incorrect answers.
* **Implementation:** Overrides `IsCorrect()` to evaluate user submissions against the designated correct answer, returning a boolean result.

### 3. `GAMEMANAGER` (Core Logic & Controller)

Acts as the central engine managing data structures and randomization workflows:

* **Data Structure:** Implements a 2D array/matrix structure of size **($5 \times 15$)** to categorize 5 questions across 15 progressive difficulty tiers.
* **Key Methods:**
* `LoadQuestions(string path)`: Reads and parses the text database file line-by-line according to strict file formatting rules.
* `GetRandomQuestion(int level)`: Selects a random question from the pool dedicated to the current level using a secure pseudo-random number generator.
* `GetShuffledAnswers(Question q)`: Randomly mixes the correct answer with incorrect choices to prevent predictable positioning on the GUI.



---

## 🎮 Game Rules & Lifelines (Helps)

* **15-Level Prize Ladder:** Players climb through 15 stages of escalating difficulty aiming for the grand prize.
* **Available Lifelines:**
* **50:50:** Programmatically disables or removes two incorrect options from the active choices.
* **Change Question:** Discards the current active question and pulls a fresh random alternative from the same level tier.
* **Audience Poll:** Simulates statistical audience feedback distribution.



---

## 🛠️ Technology Stack

* **Language:** C#
* **Framework:** .NET / Windows Forms (GUI)
* **Paradigm:** Object-Oriented Programming (OOP)

---

## 🚀 Getting Started & Execution

1. **Clone the Repository:**
```bash
git clone https://github.com/AUBAI-ALKHABBAZ/-Who-Wants-To-Be-A-Millionaire-game-in-C-.git
cd -Who-Wants-To-Be-A-Millionaire-game-in-C-/Millionaire_Game_Project

```


2. **Open in Visual Studio:**
Open the solution file (`.sln`) in Visual Studio with Windows Forms workload enabled.
3. **Configure Question Database:**
Ensure the pre-formatted text file containing questions is placed in the correct execution directory path expected by `GameManager.LoadQuestions()`.
4. **Build and Run:**
Compile the project and launch the executable via Visual Studio or the .NET CLI (`dotnet run`).

---

## 👤 Author

**AUBAI ALKHABBAZ**

*Mechatronics & Information Technology Engineer specializing in Machine Learning, Cyber-Physical Systems, and Software Engineering.*

<img width="760" height="482" alt="Screenshot 2026-03-24 033924" src="https://github.com/user-attachments/assets/68ed5932-082d-479d-916e-894e97443a79" />
