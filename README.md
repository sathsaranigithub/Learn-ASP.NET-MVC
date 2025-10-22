# Learn-ASP.NET-MVC

MVC is a **design pattern** that separates an application into three main components: **Model**, **View**, and **Controller**.

---

<img width="728" height="472" alt="image" src="https://github.com/user-attachments/assets/7cbcb373-e120-48e9-83a8-be9eba079d0a" />

---

## 🧩 Scenario Analysis

> "I have a service station. I do different services for few types of vehicles.  
> I do services for Cars, Vans and Bikes.  
> I also have my staff assigned to these services.  
> I need to see a progress of all services.  
> Also I keep a track of my customers."

---

## 📘 Identified Models

| Underlined Word | Model Name | Description |
|------------------|-------------|--------------|
| **services** | `Service` | Represents different services offered (e.g., Oil Change, Washing, Engine Tune-Up, etc.) |
| **vehicles** | `Vehicle` | Represents vehicle types (Car, Van, Bike) and related details (brand, number, etc.) |
| **staff** | `Staff` | Represents employees working in the service station (mechanics, cleaners, etc.) |
| **customers** | `Customer` | Represents people who bring their vehicles for service |

---

## ⚙️ How MVC Works (ASP.NET MVC Flow)

1. **User** sends a request to the **Controller** through the browser (for example, `/Service/Details/1`).
2. The **Controller** receives the request and interacts with the **Model** if data is needed.
3. The **Model** communicates with the **Database** to fetch or update data.
4. The **Database** sends the data back to the **Model**.
5. The **Model** sends the data back to the **Controller**.
6. The **Controller** passes the data to the **View**.
7. The **View** displays the data to the **User** as a web page.

---

<img width="1332" height="695" alt="image" src="https://github.com/user-attachments/assets/26bc10ab-58c1-464b-98f3-dfc4245beb7d" />

---

✨ *This repository is created to help beginners learn the ASP.NET MVC architecture and understand how data flows between Model, View, and Controller.*
