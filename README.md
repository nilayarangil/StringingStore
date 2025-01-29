<!-----



Conversion time: 0.629 seconds.


Using this Markdown file:

1. Paste this output into your source file.
2. See the notes and action items below regarding this conversion run.
3. Check the rendered output (headings, lists, code blocks, tables) for proper
   formatting and use a linkchecker before you publish this page.

Conversion notes:

* Docs to Markdown version 1.0β40
* Wed Jan 29 2025 08:42:03 GMT-0800 (PST)
* Source doc: Untitled document
* This is a partial selection. Check to make sure intra-doc links work.
----->



# **Tennis String Job Tracking System with ASP.NET MVC and C#**

This wiki documents the **Tennis String Job Tracking System** built using **ASP.NET MVC**, **C#**, **SQL Server**, and **Entity Framework**. The system was developed to help keep track of tennis string jobs for **FirstRaquet.org**, a non-profit organization. The application is used to capture and manage important details related to each string job, such as the customer’s information, string type, string tension, and string pattern.


---


## **1. Project Overview**

The **Tennis String Job Tracking System** is a web application designed to streamline the process of tracking string jobs for tennis rackets. The system allows administrators to:



* Capture customer details (name, contact information).
* Record specific string job information such as the string type, tension, and pattern.
* View and manage all string job entries in an organized manner.

The backend is powered by **SQL Server** and uses **Entity Framework** for ORM to interact with the database. The project was developed using **ASP.NET MVC** with **C#**, providing a clean separation of concerns and ensuring a maintainable architecture.


---


## **2. Features of the Tennis String Job Tracking System**


### **2.1. Job Management**



* **Create String Jobs**: Admins can create new string job entries by filling out the form with customer and string job details.
* **Edit and Delete Jobs**: Admins can update or delete existing string job records.


### **2.2. String Job Details**



* **Customer Information**: Record the customer’s name, contact details (email, phone number), and job-specific notes.
* **String Type**: Track which type of tennis string is used for the job (e.g., synthetic, natural gut, polyester).
* **String Tension**: Record the tension at which the string is strung, providing information for the customer’s preferred setup.
* **String Pattern**: Specify the string pattern (e.g., 16x19, 18x20) used for the racket.


### **2.3. Job Overview**



* Admins can view a list of all string jobs in a table format, with filtering options to sort by customer name, string type, or date of the job.


---


## **3. Usage**


### **3.1. Creating a String Job**



1. Navigate to the "Create Job" section from the navigation menu.
2. Enter the customer’s details (name, email, phone).
3. Select the string type, string tension, and pattern.
4. Click **Save** to create the string job entry.


### **3.2. Managing String Jobs**



1. Navigate to the "View Jobs" section to see all the string jobs in a table format.
2. Use filters to search for jobs by customer name or string type.
3. Click on any job entry to view its details or edit it.
4. You can also delete any job from the list.


---


## **4. Future Enhancements**

The **Tennis String Job Tracking System** can be extended with the following features:



* **Reporting**: Generate reports based on string type, tension, or customer details.
* **Email Notifications**: Send email notifications to customers when their job is completed.
* **Job History**: Keep a history of past jobs for each customer to track their preferences.


---


## **5. Conclusion**

Building the **Tennis String Job Tracking System** with **ASP.NET MVC**, **C#**, **SQL Server**, and **Entity Framework** helped me improve my understanding of web development, **C#** programming, and the MVC architecture. This project allowed me to manage and streamline the string job process at **FirstRaquet.org**.

The system’s features make it easy to capture, manage, and search for string jobs, improving the efficiency of handling customer requests.
