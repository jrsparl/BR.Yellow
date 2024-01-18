document.getElementById('scrollButton').addEventListener('click', function () {
    // Scroll down by the height of the viewport
    window.scrollBy({
        top: window.innerHeight, // Vertical scroll amount
        behavior: 'smooth' // Smooth scroll
    });
});