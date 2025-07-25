# Milestone 4: Development (Coding Phase)

**Course:** CST-451: Senior Project I  
**Student:** Alex Frear  
**Project Title:** Medical Journey Log: A Family Care Tracker  
**Date:** July 2025

---

## 📌 Overview

Milestone 4 focuses on building the first functional version of the Medical Journey Log application. This tool is designed to help caregivers document a child's health journey by logging symptoms and other key observations over time.

For this milestone, I implemented:
- The full Razor Pages structure
- Models and database integration
- UI forms for logging children and symptoms
- A working application that stores and retrieves records
- A narrated screencast demonstrating the features

---

## 🧱 Tech Stack

| Category       | Tool/Framework               |
|----------------|------------------------------|
| Frontend       | ASP.NET Razor Pages (C#)     |
| Backend        | .NET 7 SDK                   |
| Database       | MySQL (via MySQL Workbench)  |
| Platform       | macOS (2018 MacBook Pro)     |
| IDE            | Visual Studio for Mac        |
| Version Control| Git & GitHub                 |

---

## 🚀 Features Completed

### ✅ Add Child
- Created the `/LogChild` Razor Page
- Accepts Name and Date of Birth
- Includes input validation and error messages
- On successful submission, stores the child record in MySQL and redirects to the homepage

### ✅ Log Symptom
- Built the `/LogSymptom` Razor Page
- Dropdown list to select an existing child
- Fields for symptom name, description, and date logged
- Supports optional `childId` query string to pre-fill selection
- Form data is validated and saved

### ✅ View Child Details
- Developed the `/ChildDetails` page
- Displays child’s name and birthdate
- Lists all logged symptoms
- Includes a button to log a new symptom directly from the details page

---

## 🧬 Models Implemented

| Model     | Fields                                                                 |
|-----------|------------------------------------------------------------------------|
| `Child`   | Id, Name, DateOfBirth, ICollection<Symptom>                            |
| `Symptom` | Id, Name, Description, DateLogged, ChildId (FK), Navigation to Child   |

Models use validation attributes like `[Required]`, `[DataType]`, and `[StringLength]`. These models are bound to Razor PageModel properties using `get` and `set` so the UI can interact with the database correctly.

---

## 🗃️ Database Schema

- Local MySQL database
- `.sql` dump file included in repo: `Dump20250720.sql`
- Tables:
  - `Children`
  - `Symptoms`
- One-to-many relationship from Child → Symptoms

---

## 🔐 Security

- HTTPS is configured using a trusted macOS development certificate
- ASP.NET form validation prevents bad input
- All features are built for local use only — no public endpoints or external authentication in this version

---

## 🎥 Screencast Summary

The recorded screencast shows:
- Adding a child via the Log Child form
- Logging a new symptom using the dropdown and date fields
- Navigating to the Child Details page to view the full symptom history
- Seeing how form validation works with clear error messages
- The success messages that appear when saving data
- Data stored and confirmed via MySQL Workbench

The screencast has been submitted with the Milestone 4 deliverables.

---

## 📂 Project Files

- `MedicalJourneyLog/` – Full application code
- `Dump20250720.sql` – Database export file
- Weekly Capstone Status Reports for Weeks 9 & 10
- This `README.md`
- Screencast video
- Milestone 4 PDF submission

---

## ✅ Rubric Checklist

| Requirement                              | Completed ✅ |
|------------------------------------------|--------------|
| Razor Pages scaffolded                   | ✅           |
| Models and MySQL schema implemented      | ✅           |
| Razor forms to input data                | ✅           |
| Form validation and error handling       | ✅           |
| Screenshot or screencast                 | ✅           |
| Database `.sql` export                   | ✅           |
| Source control via GitHub                | ✅           |
| README file describing features          | ✅           |

---

## 📎 GitHub Repo

All code and resources for this milestone are committed to:  
🔗 [GitHub Repository Link](https://github.com/amfrear/MedicalJourneyLog)

---

## ✅ Final Notes

The application runs successfully with HTTPS, handles form data reliably, and connects seamlessly to MySQL. All milestone requirements have been completed, including full implementation, testing, GitHub version control, and video walkthrough. This version sets a strong foundation for the additional features to come in Milestone 5.

---
