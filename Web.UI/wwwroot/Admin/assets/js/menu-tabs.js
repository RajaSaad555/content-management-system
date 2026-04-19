const navbarContainer = document.getElementById("navbar");

window.addEventListener("scroll", () => {
  const scrollValue = window.scrollY;

  const navbarContainer = document.getElementById("navbar");
  if (scrollValue > 300) {
    navbarContainer.classList.add("navbar-full");
  } else {
    navbarContainer.classList.remove("navbar-full");
  }
});

document.querySelectorAll(".nav-item").forEach((container) => {
  const tabLinks = container.querySelectorAll(".tab-link");
  const tabContents = container.querySelectorAll(".tab-content");

  // helper: show first content by default
  function showFirstContent() {
    if (tabContents.length > 0) {
      tabContents[0].classList.add("active");
    }
  }

  // initialize first content
  showFirstContent();

  tabLinks.forEach((link) => {
    link.addEventListener("click", (e) => {
      e.preventDefault();

      const tabId = link.getAttribute("data-tab");
      const targetContent = container.querySelector(`#${tabId}`);

      const isActive = link.classList.contains("active");

      // Remove active from this container only
      tabLinks.forEach((tab) => tab.classList.remove("active"));
      tabContents.forEach((content) => content.classList.remove("active"));

      if (!isActive) {
        // Activate clicked tab + content
        link.classList.add("active");
        if (targetContent) targetContent.classList.add("active");
      } else {
        // If toggled off, show first content
        showFirstContent();
      }
    });
  });
});

document.addEventListener("DOMContentLoaded", () => {
  const navItems = document.querySelectorAll(".nav-item.nav-with-dropdown");

  navItems.forEach((item) => {
    const navLink = item.querySelector(".nav-link");
    const dropdown = item.querySelector(".dropdown-custom-container");

    if (!navLink || !dropdown) return;

    navLink.addEventListener("click", (e) => {
      e.preventDefault();

      // Close any other open dropdowns first
      document
        .querySelectorAll(".dropdown-custom-container.drop-down-active")
        .forEach((openDropdown) => {
          if (openDropdown !== dropdown) {
            openDropdown.classList.remove("drop-down-active");
          }
        });

      // Toggle active class on this dropdown
      dropdown.classList.toggle("drop-down-active");
    });
  });

  // Optional: close dropdowns when clicking outside
  document.addEventListener("click", (e) => {
    const isInsideNav = e.target.closest(".nav-item.nav-with-dropdown");
    if (!isInsideNav) {
      document
        .querySelectorAll(".dropdown-custom-container.drop-down-active")
        .forEach((openDropdown) =>
          openDropdown.classList.remove("drop-down-active")
        );
    }
  });
});
