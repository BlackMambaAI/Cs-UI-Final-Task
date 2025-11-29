Structure:
Project Overview
•	Program.cs → Entry point, launches FormLogin.
•	FormLogin (Form1) → Login screen with password hashing, validation, and navigation to the dashboard.
•	FormCreateNewAccount (Form2) → First step of sign up (username + password).
•	FormUserInformation (Form3) → Second step of sign up (personal details, validation, save to JSON).
•	FormShowInformation (Form4) → Main dashboard: personal info, courses, notifications, search, and send notifications.
Data Models
•	UserInfo.cs → User account details.
•	Notification.cs → Messages between users.
•	MajorsData.cs / Major.cs / Course.cs → Academic structure.
Features
•	Secure login with SHA 256 password hashing.
•	Sign up with validation (ID, full name, phone, email).
•	Age calculation (integer + decimal precision).
•	Courses tied to selected major.
•	Notifications system with “starred” persistence.
•	Search users by name/email and send notifications.
•	Set labels and text boxes colors.
Complete mini system:
1.	Login → validates credentials.
2.	Sign up → creates new account with personal info.
3.	Dashboard → shows personal info, courses, notifications, allows communication, and control visuality.

