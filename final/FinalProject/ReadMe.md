Financial Tracker Console App

Overview
This project is a console-based financial tracker. It allows users to record income and expense transactions, view summaries, set savings goals, and generate reports. The application supports multiple types of income and expenses, including recurring and interval-based entries.

The project is designed using object-oriented programming principles: **abstraction**, **encapsulation**, **inheritance**, and **polymorphism**.

---

Features

- Add different types of transactions:
  - Income: LumpSum, Recurring, Interval
  - Expense: One-Time, Recurring, Interval
- Set and change an annual savings goal
- View all transactions
- Generate a weekly cash flow report
- Track year-to-date (YTD) progress toward savings goal
- Write transaction reports to a file
- Read saved reports from a file

---

How to Run

All you need to do is click run in the upper right hand corner of VSCODE

---

Usage Notes

- When creating a transaction, follow the prompts to select a type and enter the required information (name, amount, category, etc.).
- All dates should be entered in the format: `yyyy-mm-dd`
- File names for saving or reading reports should include `.txt` (e.g., `report.txt`) automatically
- Only valid numeric inputs will be accepted for amounts, dates, and intervals.
- Interval-based transactions require a start date, end date, and how often they repeat (in days).

---


