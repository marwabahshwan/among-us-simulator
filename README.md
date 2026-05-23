# 🚀 Among Us: The C# Console Game

A complete, text-based simulation of the popular game **Among Us**, developed entirely within the C# console environment.

![Project Banner](banner.png)

---

## 📖 About the Game
This project brings the strategic, social-deduction gameplay of *Among Us* into a text-based console experience. Players find themselves navigating through a series of logical levels, trying to complete essential tasks while guessing who the hidden Impostor is before it's too late!

### 🎮 How It Works
1. **Setup & Lobby:** Upon launching the game, you will be prompted to set up your session by entering the total number of players (supports between 5 to 10 players).
2. **Player Names Setup:** The game lets you dynamically input the names for all players.
3. **Automated Role Selection:** The system secretly and randomly assigns roles, picking who is a Crewmate and who is the hidden Impostor.
4. **Navigating the Levels:** Players progress sequentially through 3 interactive rooms to investigate and complete tasks:
   - ⚡ **Level 1 (Power Room):** Fix broken cables and find lost ID cards.
   - 🔒 **Level 2 (Security Room):** Watch cameras and monitor crewmate activity.
   - 📦 **Level 3 (Storing Room):** Inspect the floor, look for clues, and handle dynamic messages.
5. **The Voting Phase:** The game triggers a custom voting interface where you must review the suspects and cast your vote to eliminate the suspected Impostor!

---

## 📌 Key Features
* **Dynamic Player Configuration:** Customizable player slots (5-10 players) with custom name entry.
* **Randomized Logic System:** Automated backend role assignment to ensure every playthrough is unpredictable.
* **Console-Based ASCII Art Assets:** Custom text-graphics and voting boards to enhance the experience.
* **Interactive Choices:** Smooth progression handling using simple numerical choices (`[1], [2], [3]`) for user actions.

---

## ⚠️ Important Guidelines
* This is a logic-focused console application and does not require an external GUI library.
* To avoid application exceptions, players must strictly follow the input rules and use the designated numbers displayed on screen.

---

## 💻 Project Context
This is our very first programming project! We developed it as a team, collaborating on the code as part of a practical assignment for our Level 1 Programming course (C#) in our IT degree. It was designed as an opportunity to put our learning into practice by applying fundamental coding concepts—such as methods, parameters, arrays, loops, and randomized logic—to build a clean and functional console application.# among-us-simulator
A text based Among Us game developed in C#
