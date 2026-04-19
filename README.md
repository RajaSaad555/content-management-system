<img width="1346" height="636" alt="7" src="https://github.com/user-attachments/assets/7d4b5688-3cb7-4b6f-b327-93e17a9a28b1" />
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

<img width="1353" height="627" alt="2" src="https://github.com/user-attachments/assets/65044865-1906-45fd-bb28-5104e0a739a0" />


---

### Product Categories
Full hierarchical category system — **Brand → Category → Subcategory → Sub-subcategory** — each with its own image.

<img width="1342" height="630" alt="3" src="https://github.com/user-attachments/assets/01ab5336-176e-4ab8-b2b7-bb93b6cbaa15" />

---

### Product Management
Add, edit, and delete products with images, rich descriptions (Summernote editor), and category assignment.

<img width="1353" height="637" alt="4" src="https://github.com/user-attachments/assets/f10abcf1-fd41-43c3-bb7d-f314dfa05d4e" />

---

## 🌐 Public Website

### Brand Navigation with Mega Menu
Each brand (i-flex, i-connect, i-power) has a rich dropdown mega menu showing product lines, subcategories, and catalogues — all driven from the CMS.

<img width="1350" height="642" alt="8" src="https://github.com/user-attachments/assets/a0b9df69-0119-4ca7-9d78-7a2ceada1ae7" />
<img width="1345" height="635" alt="6" src="https://github.com/user-attachments/assets/f0dec499-3f40-4e89-af9d-9082ca9c7a00" />
<img width="1342" height="637" alt="5" src="https://github.com/user-attachments/assets/70e03cbd-2dd6-4878-8c6b-508d00879df0" />


---

### Product Detail Pages
Rich product pages with full descriptions, multiple images, tabbed sections (Product Info, Features & Specifications, Applications, Documents & Downloads), and a "Request a Quote" CTA.

<img width="1346" height="636" alt="7" src="https://github.com/user-attachments/assets/f5ee968c-08bf-4625-af1e-451df26b5585" />

---

### Blog & Insights
Blog listing and detail pages managed entirely from the admin panel — with categories, authors, and dates.

<img width="1346" height="636" alt="9" src="https://github.com/user-attachments/assets/416be13c-2766-4cba-94bb-39b094783771" />

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

