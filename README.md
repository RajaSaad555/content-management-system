<img width="1347" height="638" alt="1" src="https://github.com/user-attachments/assets/5e9e2795-7843-4860-817a-f4aae11d4fe7" />
# ⚡ Interconnect Solutions — Content Management System

A full-featured **Content Management System** built with **ASP.NET MVC** for managing the complete digital presence of **Interconnect Solutions** — powering brands like **i-flex**, **i-connect**, and **i-power** across product lines including RF Cables, UPS Systems, LAN Solutions, and more.

Every aspect of the website — products, categories, pages, blogs, sliders, and inquiries — is fully manageable through a dedicated **Admin Panel**, with no coding required.

---

## 🏷️ Brands Managed

| Brand | Description |
|-------|-------------|
| **i-flex** | RF & DAS passive products for in-building and outdoor telecom coverage |
| **i-connect** | LAN, copper & optical cabling solutions (CAT6, CAT6A, CAT7A, Fibre) |
| **i-power** | UPS systems, batteries, AVRs, and power inverters |

---

## 🖥️ Admin Panel

### Dashboard
Real-time overview of all content — Posts, Pages, Categories, Authors, and Inquiries.

<img width="1347" height="638" alt="1" src="https://github.com/user-attachments/assets/25abf548-4850-4f86-9704-35ebb9de5aee" />

---

### Page Management
Create and manage all website pages with parent-child relationships and inner page support.

![Page List](screenshots/2.png)

---

### Product Categories
Full hierarchical category system — **Brand → Category → Subcategory → Sub-subcategory** — each with its own image.

![Product Categories](screenshots/3.png)

---

### Product Management
Add, edit, and delete products with images, rich descriptions (Summernote editor), and category assignment.

![Manage Products](screenshots/4.png)

---

## 🌐 Public Website

### Brand Navigation with Mega Menu
Each brand (i-flex, i-connect, i-power) has a rich dropdown mega menu showing product lines, subcategories, and catalogues — all driven from the CMS.

![i-flex Mega Menu](screenshots/5.png)
![i-flex Product Line](screenshots/6.png)
![i-power UPS Menu](screenshots/8.png)

---

### Product Detail Pages
Rich product pages with full descriptions, multiple images, tabbed sections (Product Info, Features & Specifications, Applications, Documents & Downloads), and a "Request a Quote" CTA.

![Product Detail - RF Leaky Cable](screenshots/7.png)

---

### Blog & Insights
Blog listing and detail pages managed entirely from the admin panel — with categories, authors, and dates.

![Blog & Insights](screenshots/9.png)

---

## ✨ Key Features

- **Full CMS control** — Edit any product name, description, image, or page content from the admin
- **Summernote rich text editor** — Format product descriptions with full HTML support
- **Hierarchical categories** — Unlimited depth: Category → Subcategory → Sub-subcategory → Product
- **Multi-brand architecture** — Separate management for i-flex, i-connect, and i-power
- **Page builder** — Create inner pages with parent-child relationships
- **Slider management** — Update homepage banners from the admin
- **Blog & categories** — Publish articles with authors and categories
- **Inquiry management** — View and track user inquiries from the admin panel
- **Author management** — Assign blog posts to multiple authors

---

## 🏗️ Architecture

Clean **3-Layer (N-Tier) Architecture**:

```
content-management-system/
│
├── BusinessObject/
│   └── Service/              # Business logic layer
│
├── DataAccess/
│   └── Model/                # Entity Framework models & DB context
│
└── Web.UI/
    ├── Controllers/           # Public website controllers
    ├── Areas/
    │   └── Admin/
    │       └── Controllers/   # Admin panel controllers
    └── Views/                 # Razor views (.cshtml)
```

---

## 🛠️ Tech Stack

| Layer | Technology |
|-------|-----------|
| Frontend | HTML5, CSS3, JavaScript, Bootstrap |
| Rich Text Editor | Summernote |
| Backend | C#, ASP.NET MVC (.NET Framework) |
| ORM | Entity Framework |
| Database | SQL Server |
| Architecture | 3-Layer (Presentation, Business, Data) |

---

## 🔒 Code Access

> **Note:** Due to a confidentiality agreement, the full source code is not publicly available in this repository.
> To review the code, feel free to reach out via the **comments section** or contact directly on GitHub.

---

## 👨‍💻 Author

**Raja Saad**
- GitHub: [@RajaSaad555](https://github.com/RajaSaad555)

