document.addEventListener('DOMContentLoaded', function () {
    const triggers = document.querySelectorAll('.dropdown-trigger');

    triggers.forEach(trigger => {
        trigger.addEventListener('click', function (e) {
            e.preventDefault();
            const targetId = this.getAttribute('data-dropdown');
            const dropdown = document.getElementById(targetId);

            if (!dropdown) {
                console.warn('No dropdown found for id:', targetId);
                return;
            }

            // close any other open dropdowns
            document.querySelectorAll('.mega-dropdown.open').forEach(el => {
                if (el.id !== targetId) el.classList.remove('open');
            });

            dropdown.classList.toggle('open');
        });
    });

    // close dropdown when clicking a real link inside it (so it doesn't stay open after navigating)
    document.querySelectorAll('.mega-dropdown a').forEach(link => {
        link.addEventListener('click', function () {
            document.querySelectorAll('.mega-dropdown.open').forEach(el => el.classList.remove('open'));
        });
    });

    // close dropdown when clicking outside
    document.addEventListener('click', function (e) {
        if (!e.target.closest('.has-dropdown')) {
            document.querySelectorAll('.mega-dropdown.open').forEach(el => el.classList.remove('open'));
        }
    });
});