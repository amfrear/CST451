# Milestone 3: Final Architectural Plan (Design Phase)

**Course:** CST-451: Senior Project I  
**Student:** Alex Frear  
**Project Title:** Medical Journey Log: A Family Care Tracker  
**Date:** July 2025

---

## 🧠 Overview

This milestone translates the requirements gathered in Milestone 2 into a detailed technical design and architecture blueprint for the *Medical Journey Log* application. The system is designed to help caregivers track and manage the health journey of family members with complex medical needs.

The Final Architectural Plan includes:

- System architecture and data flow
- C# object definitions and MySQL schema
- Wireframes and screen specifications
- Sequence diagrams and pseudocode
- Security considerations
- Hardware and configuration setup

---

## 🧩 Key Components

### 1. Technical Stack

| Layer        | Technology                 |
|-------------|-----------------------------|
| Frontend     | ASP.NET Razor Pages         |
| Backend      | C# (.NET Core)              |
| Database     | MySQL (local instance)      |
| IDE          | Visual Studio for Mac       |
| Versioning   | GitHub (local only)         |

### 2. System Architecture

- **Single Caregiver Account** (offline, local use)
- Layered design with UI, logic, and data access separation
- All features support fast, form-based entry and reporting
- Local-only deployment: no cloud sync or external APIs

### 3. Database & Object Models

Five key entities:

- `FamilyMember`
- `SymptomEntry`
- `Appointment`
- `JournalEntry`
- `ReportService`

Each includes both the MySQL schema and C# class definition with responsibilities outlined.

### 4. UI Wireframes

Screens designed in a consistent macOS-style layout:

| Screen              | Purpose                                    |
|---------------------|--------------------------------------------|
| Dashboard           | Summary view with action buttons           |
| Log Symptom         | Add symptom details with dropdowns/date    |
| Appointment Manager | Calendar UI to manage appointments         |
| Journal Entry       | Date-stamped notes for reflection          |
| Reports             | Filter and export entries to PDF           |

---

## 🔄 Sequence Diagram

The milestone includes a step-by-step diagram for the `Log Symptom` use case, illustrating user interaction from form submission to database storage.

---

## 🔐 Security & Privacy

The application assumes local, trusted access. Key considerations:

- Single caregiver login (no multi-user control)
- No external transmission of data (offline mode)
- Local database storage with optional MySQL user permissions
- Future support for encryption is noted for scalability

---

## 💻 Hardware & Configuration

### Required Tools

- macOS 10.15 or later  
- Visual Studio for Mac (Community Edition)  
- .NET Core SDK (latest supported version)  
- MySQL Community Server (8.x)  
- GitHub (for local version control)

### Environment Variables

Configured via launch settings or user secrets:

```
DB_HOST=localhost  
DB_PORT=3306  
DB_USER=root  
DB_PASSWORD=yourpassword  
DB_NAME=familycaretracker  
```

---

## 📁 Files

- `Milestone 3 Final Architectural Plan (Design Phase).pdf` – Final deliverable  
- `Weekly Capstone Project Status Report Week 5.xlsx`  
- `Weekly Capstone Project Status Report Week 6.xlsx`  
- `Weekly Capstone Project Status Report Week 7.xlsx`  
- `Weekly Capstone Project Status Report Week 8.xlsx`

---

## ✅ Submission Notes

- All diagrams, definitions, and technical specs align with the CST-451 Capstone Project Handbook and rubric  
- Includes full UI specifications, data definitions, and architecture planning for development in Milestone 4  
- Document reviewed and finalized for submission on July 9, 2025
