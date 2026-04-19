window.addEventListener("load", () => {
  const loader = document.getElementById("loader");
  loader.classList.add("hidden"); // fade out loader
  setTimeout(() => {
    loader.style.display = "none"; // remove completely
  }, 1000); // wait for fade transition
});
