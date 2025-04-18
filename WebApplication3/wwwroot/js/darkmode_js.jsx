document.addEventListener("DOMContentLoaded", () => {
    const toggle = document.getElementById("darkModeToggle");
    const icon = document.getElementById("darkModeIcon");

    const isDark = localStorage.getItem("darkMode") === "true";

    setDarkMode(isDark);

    toggle.addEventListener("click", () => {
        const isDark = document.body.classList.toggle("dark-mode");
        document.querySelectorAll(".navbar, .footer, .card").forEach(el => el.classList.toggle("dark-mode"));
        localStorage.setItem("darkMode", isDark);
        updateIcon(isDark);
    });

    function setDarkMode(state) {
        if (state) {
            document.body.classList.add("dark-mode");
            document.querySelectorAll(".navbar, .footer, .card").forEach(el => el.classList.add("dark-mode"));
        }
        updateIcon(state);
    }

    function updateIcon(isDark) {
        if (!icon) return;
        icon.className = isDark ? "bi bi-sun-fill" : "bi bi-moon-fill";
    }
});
