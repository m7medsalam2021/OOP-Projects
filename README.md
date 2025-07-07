🧰 C# Console Applications
✅ This repository contains two separate console-based projects developed in C# using Object-Oriented Programming (OOP) principles:
📘 1. Examination System
📄 Description
The Examination System is a console application that simulates an exam environment. It allows users to create and take exams for specific subjects.
It supports both practical and final exams with different types of questions and automatic grading.

🧱 Classes & Structure
1. Subject
Represents a subject in the system.

Allows creation of exams, sets type (practical/final), duration, and number of questions.

Calculates the full grade.

2. Exam (abstract)
Base class for all exams.

Contains common properties: duration, question list, total grade.

Defines method to display and evaluate answers.

3. PracticalExam (inherits from Exam)
Represents a practical exam.

Allows user interaction and grading.

4. FinalExam (inherits from Exam)
Represents a final exam.

Includes user interface for answering and auto-grading.

5. QuestionBase (abstract)
Base class for all question types.

Includes: body, mark, answer list, right answer.

Provides indexers for accessing answers.

6. TFQuestions, MCQQuestions, ChooseOneQuestions
Specialized question types derived from QuestionBase.

Each supports unique formats (true/false, multiple-choice, single choice).

Methods to define answers and evaluate input.

▶️ Usage
Run the app.

Create a subject and define the exam type.

Enter the exam questions.

Answer the exam and view your score.

🏆 2. Premier League Fixtures Generator
📄 Description
This console application simulates building a full league fixtures table between football teams.
Users input the teams and stadiums, and the system generates a full home-and-away round-robin schedule with assigned match dates.

🧱 Classes & Structure
1. Team
Represents a football team.

Stores name, stadium, and its matches.

Provides methods to view its match list.

2. Match
Represents a match between two teams.

Includes round number, home/away teams, match place, and scheduled date.

3. LeagueManager
Manages all teams and matches.

Core methods:

AddTeam(size): Adds teams to the league.

GenerateFixtures(): Creates full round-robin matches.

ScheduleMatchDates(startDate): Assigns match dates sequentially.

4. MatchPlace (enum)
Indicates whether a match is Home or Away.

▶️ Usage
Run the program.

Input the number of teams, team names, and stadiums.

The system generates home & away matches.

You provide a starting date, and the system schedules all matches.

View team-wise or full match list.

🧪 OOP Concepts Used in Both Projects
✅ Classes & Objects

✅ Inheritance

✅ Abstraction (Abstract Classes & Methods)

✅ Polymorphism

✅ Encapsulation

✅ Access Modifiers (private, public, protected)

✅ Indexers

✅ Enums

✅ Static Methods & Factory Methods

🛠️ Installation
Clone or download the project.

Open the solution in Visual Studio.

Build and run the individual project from the Main method.

Requires .NET Core runtime installed.

📦 Dependencies
No external libraries or NuGet packages.

Fully compatible with .NET Core Console Application.

