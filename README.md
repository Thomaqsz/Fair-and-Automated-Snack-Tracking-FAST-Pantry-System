# FAST: Fair and Automated Snack Tracking Pantry System

**Note: This is an academic research project developed as a requirement for the Bachelor of Science in Computer Engineering program at Colegio de Muntinlupa. It is intended for educational and demonstration purposes only.**

The **Fair and Automated Snack Tracking (FAST)** system is a paperless solution designed to manage snack distribution in a school pantry setting. The system's primary goal is to ensure a fair, efficient, and organized process while strictly enforcing a "one-claim-per-day" policy through digital verification.

## 📌 Project Overview
Manual logbooks are often prone to errors, paper waste, and difficulties in enforcing distribution rules. The FAST system digitizes this process to provide real-time tracking, inventory management, and accountability.

### Key Features
* **Paperless Operation**: Replaces physical logbooks with a digital database to reduce environmental impact.
* **Student Verification**: Ensures strict compliance with distribution policies (one claim per day).
* **Real-Time Claim Status**: Automatically updates and displays whether a student is eligible for a snack.
* **Inventory Monitoring**: Tracks which items are most popular and identifies when supplies need restocking.
* **Automated Reporting**: Generates data-driven reports on distribution trends and pantry usage.

## 🛠️ Technical Stack
* **Language**: PHP / HTML / JavaScript
* **Database**: MySQL
* **Styling**: CSS (User-Friendly UI)
* **Environment**: Localhost (XAMPP/WAMP) or Web-based Hosting

## 💻 System Requirements
| Requirement | Minimum Specification |
| :--- | :--- |
| **Operating System** | Windows, macOS, or Linux |
| **Browser** | Chrome, Firefox, or Edge |
| **Server** | Apache (XAMPP Recommended) |
| **Database** | MySQL |

## 🚀 Setup & Installation
1. Clone the repository to your local machine.
2. Move the project folder to your `htdocs` directory (if using XAMPP).
3. Import the provided `.sql` file into your MySQL database via phpMyAdmin.
4. Update the database connection settings in the configuration file:
   ```php
   $servername = "localhost";
   $username = "root";
   $password = "";
   $dbname = "fast_pantry_db";

## 👥 Contributors
De Gamo, Christian
Merto, Haniel Kristen
Moreno, Russell

