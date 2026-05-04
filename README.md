# Erasmus Eligibility & Level Checker 🇪🇺✈️

This is a decision-making application developed as part of my second day (**May 4th**) in the C# intensive learning marathon. It demonstrates the use of control flow and conditional logic in C#.

## 📌 Project Overview
The application simulates an Erasmus application system. It manages user information and directs the user to different modules based on their selection using advanced decision structures.

## 🛠 Features & C# Concepts
- **Switch-Case Structures:** Used to create a menu-driven navigation between "Apply Page" and "Result Page".
- **Nested If-Else Logic:** Used to verify application status and evaluate Erasmus scores.
- **Data Categorization:** Provides feedback on English proficiency levels (e.g., B1, B1+, B2) based on the user's exam results.
- **User Input Handling:** Captures and processes string and integer data from the console.

## 📊 Logic Flow
1. **Welcome Screen:** Collects user credentials (name, ID).
2. **Menu Selection:** The user chooses to apply or check results.
3. **Status Check:**
    - If "Apply" is selected: Confirms application receipt.
    - If "Result" is selected: Checks if an application exists, then evaluates the score.
    - **65+:** Passed
    - **55-64:** B1+ (Very close to target!)
    - **Under 55:** Needs more practice.

## 🚀 Future Improvements
- Implement `ToLower()` or `ToUpper()` methods to make string comparisons case-insensitive.
- Add a loop system to allow multiple checks without restarting the application.

---
*Developed by Simge - 1st Year Computer Engineering Student at Mersin University* 👩‍💻
