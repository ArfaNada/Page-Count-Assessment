# Page Count Assessment

This repository contains implementations of the **"Drawing Book (Page Count)"** problem for a technical assessment at **Eddium Tunisia** in **Python, TypeScript, Java, and C#**.
The goal is to provide a technical assessment for interns or candidates. Each language includes:

* Solution file
* Test file with multiple edge cases
* Setup instructions

---

## Part 1: Original Problem

At **Brightwood High School**, Mr. Thompson, a mathematics teacher, asks his students to open their textbooks to specific pages for today’s exercise.

Each student can **start flipping pages from the front or the back** of the book. They can only turn **one page at a time**, and the book always opens to page `1` on the right side.

* Most pages are **printed on both sides**, but the last page may be printed only on the front.
* Mr. Thompson wants to know how quickly each student can reach a specific page.

Your task is to **calculate the minimum number of pages a student must turn** to reach the target page.

**Example:**
For a book with `6` pages, if a student wants to reach page `2`:

* Starting from the front: 1 page turn
* Starting from the back: 2 page turns
* **Minimum:** 1 page turn

**Function Signature (Python Example):**

```python
def pageCount(n: int, p: int) -> int:
    pass 
```

---

## Part 2: Extended Problem (Multiple Queries)

Seeing how students perform, Mr. Thompson decides to give a **more challenging assignment**. This time, students must calculate the minimum page turns for **multiple target pages in the same book**.

**Example:**
For a book with `100` pages, and the target pages `[2, 50, 99]`, the expected output is `[1, 25, 0]`.

Your task is to write a function that efficiently calculates the **minimum page turns for an array of target pages**, without simulating each page flip individually.

**Function Signature (Python Example):**

```python
def pageCountMultiple(n: int, targets: list[int]) -> list[int]:
    pass
```

---

## Folder Structure

```
page-count-assessment/
│
├── README.md
│
├── python/
│   ├── solution.py
│   ├── test_page_count.py
│   └── requirements.txt
│
├── typescript/
│   ├── solution.ts
│   ├── pageCount.test.ts
│   ├── package.json
│   └── tsconfig.json
│
├── java/
│   ├── src/main/java/Result.java
│   ├── src/test/java/PageCountTest.java
│   └── pom.xml
│
└── csharp/
    ├── Result.cs
    ├── PageCountTests.cs
    └── PageCount.csproj
```

---

## Setup & Run Tests

### **Python**

```bash
cd python
pip install -r requirements.txt
# Run tests with unittest
python -m unittest test_page_count.py
# Or with pytest
pytest -v
```
---

## Submission Instructions

### For Candidates

To submit your solution, please follow these steps:

1. **Fork this repository** to your own GitHub account

2. **Create a new branch** with the naming convention:
   `[language]/[your-name]`

   **Examples:**

   ```bash
   git checkout -b python/john-doe
   git checkout -b java/sarah-smith
   git checkout -b typescript/mohamed-ali
   git checkout -b csharp/emma-wilson
   ```

3. **Implement your solution** in the chosen language:

   * Navigate to the appropriate language folder
   * Complete the solution file
   * Ensure all tests pass
   * You may add additional test cases if desired

4. **Commit your changes** with a descriptive message:

   ```bash
   git add .
   git commit -m "Complete page count solution for [language]"
   ```

5. **Push your branch** to the remote repository:

   ```bash
   git push origin [branch-name]
   ```

6. **Create a Pull Request** from your branch to the original repository

### Evaluation Criteria

* **Correctness**: Solution passes all test cases
* **Code Quality**: Clean, readable, and well-structured code
* **Efficiency**: Optimal algorithm performance
* **Testing**: All provided tests pass; additional tests are a plus

### Notes for Candidates

* Choose **only one language** to complete the assessment
* Make sure your solution handles all edge cases
* Include comments if necessary to explain your approach
* Ensure your code follows the language's best practices

---

## Notes

* All test files include **edge cases**: first page, last page, odd/even total pages, middle pages, large books.
* Each solution calculates the **minimum number of page turns** efficiently.
* The repository is ready to use as a **technical assessment** for Trainees. or candidates at **Eddium Tunisa**.
