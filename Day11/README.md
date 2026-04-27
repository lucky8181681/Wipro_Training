# Day11 - Unit Testing with MSTest (.NET)

## Overview
This project demonstrates unit testing in .NET using the MSTest framework.  
A simple Calculator application is implemented and tested with multiple input scenarios.

---

## Technologies Used
- C# (.NET)
- MSTest Framework
- Visual Studio

---

## Projects
- DemoTestingApp: Contains business logic (Calculator)  
- Demo.Tests: Contains unit test cases  

---

## Features Implemented
- Multiplication logic  
- Unit testing for:
  - Positive cases  
  - Zero handling  
  - Negative numbers  

---

## Test Cases
- Multiply_ShouldReturnCorrectResult  
- Multiply_WithZero_ShouldReturnZero  
- Multiply_WithNegativeNumbers_ShouldReturnNegative  

---

## Steps Followed
1. Created a console application for business logic  
2. Added an MSTest test project to the solution  
3. Linked both projects using project reference  
4. Implemented Calculator class with multiplication logic  
5. Wrote unit test cases for different scenarios  
6. Executed tests using Test Explorer in Visual Studio  

---

## How to Run
1. Open the solution in Visual Studio  
2. Build the solution  
3. Go to Test menu and select Run All Tests  

---

## Output
All test cases passed successfully for valid scenarios.  
A failing test case was also executed by intentionally modifying the expected value to demonstrate how unit tests validate logic and detect incorrect results.

---

## Conclusion
This project demonstrates how unit testing helps validate application logic by testing multiple scenarios and ensuring correctness of the implementation.