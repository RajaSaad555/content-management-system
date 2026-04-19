document.querySelectorAll(".carousel-container").forEach((container) => {
  const track = container.querySelector(".carousel-track");
  const items = container.querySelectorAll(".carousel-item-custom");
  const prevBtn = container.parentElement.querySelector(".prevBtn");
  const nextBtn = container.parentElement.querySelector(".nextBtn");

  const visibleItems = 5;
  let index = 0;

  function updateCarousel() {
    const itemWidth = items[0].offsetWidth;
    track.style.transform = `translateX(-${index * itemWidth}px)`;
  }

  if (nextBtn && prevBtn) {
    nextBtn.addEventListener("click", () => {
      if (index < items.length - visibleItems) {
        index++;
        updateCarousel();
      }
    });

    prevBtn.addEventListener("click", () => {
      if (index > 0) {
        index--;
        updateCarousel();
      }
    });
  }

  window.addEventListener("resize", updateCarousel);
  updateCarousel();
});
