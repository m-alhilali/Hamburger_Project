# 🍔 HamburgerProject - Order Management System

A sophisticated Windows Forms application built with **C#** and **Visual Studio**. This system provides a dynamic and interactive interface for customizing hamburger orders, calculating costs in real-time, and managing historical invoice data.

## 🌟 Key Features

* **Dynamic Order Customization:** Users can select from various categories including Buns, Patties, Toppings, Condiments, and Sides.
* **Real-time Price Calculation:** Automatically calculates the total price (SYR) as the user toggles different ingredients using the `Tag` property logic.
* **Interactive UX/UI:** * **Visual Feedback:** Ingredient icons update dynamically when hovering or selecting options.
    * **Animated Controls:** Buttons and checkboxes feature hover animations (size and color shifts) for a modern feel.
* **Persistent Data Storage:** Saves finalized orders into a local `Invoice.txt` file using a custom-delimited string format (`||--||`) for reliability.
* **Invoice Management:** * **Detailed View:** Generates a `DataGridView` summary of current selections with associated images and individual prices.
    * **History Logs:** Dedicated interface to load and view all previous transactions from the file system.

## 🛠 Technical Implementation

* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Architecture:** Modular design with multi-form navigation (`Form1`, `OrderDetailsForm`, `OrdersForm`).
* **Data Handling:** Advanced use of `StreamReader` and `StreamWriter` for persistent storage and `DataTable` for UI data binding.

## 📂 Project Structure

- **Form1.cs**: The main hub for order selection, price logic, and UI state management (Reset/Order).
- **OrderDetailsForm.cs**: Handles the generation of the current receipt and data visualization via tables.
- **OrdersForm.cs**: Manages the retrieval and parsing of archived order history from the text database.

---
Developed by **Mohammed Alhilali**
