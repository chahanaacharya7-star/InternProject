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

    // ===== Employee Login Management: tab switching =====
    const loginTabs = document.querySelectorAll('.login-tab');
    const tabPanels = document.querySelectorAll('.tab-panel');

    loginTabs.forEach(tab => {
        tab.addEventListener('click', function () {
            loginTabs.forEach(t => t.classList.remove('active'));
            this.classList.add('active');

            const targetTab = this.getAttribute('data-tab');
            tabPanels.forEach(panel => {
                panel.style.display = (panel.getAttribute('data-tab-panel') === targetTab) ? 'block' : 'none';
            });
        });
    });

    // ===== Employee Login Management: page size buttons =====
    const pageSizeButtons = document.querySelectorAll('.page-size');
    pageSizeButtons.forEach(btn => {
        btn.addEventListener('click', function () {
            pageSizeButtons.forEach(b => b.classList.remove('active'));
            this.classList.add('active');
        });
    });
});