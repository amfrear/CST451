# Milestone 2: Requirements (Analysis Phase)

**Course:** CST-451: Senior Project I  
**Student:** Alex Frear  
**Project Title:** Medical Journey Log: A Family Care Tracker  
**Date:** June 2025

---

## 📋 Overview

This milestone outlines the complete requirements specification for the *Medical Journey Log* Capstone project. The application is designed to help caregivers track and organize the health journey of family members with chronic or complex medical conditions.

The Requirements Specification document includes:

- Abstract and introduction
- Functional and non-functional requirements
- Technical stack and tools
- System design diagrams
- UI wireframes for all core screens
- Role-based security model
- Report generation logic

---

## ✅ Key Components

### 1. Functional Requirements
Five core user stories from the caregiver perspective were identified, covering:
- Symptom tracking
- Appointment management
- Historical trend filtering
- Journal entries
- Report exporting

### 2. Non-Functional Requirements
Performance, security, usability, availability, and portability were outlined in measurable terms.

### 3. Technical Stack
- **Frontend:** ASP.NET Razor Pages  
- **Backend:** C# with .NET Core  
- **Database:** MySQL  
- **IDE:** Visual Studio (macOS)  
- **Version Control:** GitHub (main branch)

### 4. Diagrams Included
- Logical System Design (top-down task structure)
- System Logical Model (data flow across modules)
- Security Matrix (caregiver vs guest access)
- Wireframes for all five UI screens

---

## 🧩 Screens Designed

| Screen                | Description                                 |
|-----------------------|---------------------------------------------|
| Dashboard             | Summary tiles and action buttons            |
| Log Symptom           | Symptom type, notes, and date input         |
| Appointment Manager   | Calendar view with add/edit/delete          |
| Journal Entry         | Text area with date picker and save button  |
| Reports               | Filters by date/member with export to PDF   |

---

## 🔐 Security

Role-based authorization is implemented using ASP.NET Identity. The system ensures:
- Only logged-in caregivers can access private features
- Guest users are restricted from all health data
- All data is encrypted using AES-256 and TLS

---

## 🧾 Submission Notes

- All Milestone 2 elements have been validated against the CST-451 Capstone Project Handbook and rubric
- Wireframes use a consistent Mac-style browser window format
- All diagrams and report examples are embedded within the PDF

---

## 📁 Files

- `Milestone 2 Requirements (Analysis Phase).pdf` – Final deliverable 
