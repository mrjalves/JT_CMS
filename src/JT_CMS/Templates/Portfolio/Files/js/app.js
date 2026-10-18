// ==========================================
// THEME SWITCHER & CORE INTERACTIVITY
// ==========================================
function initializeTheme() {
    const getStoredTheme = () => localStorage.getItem('theme');
    const setStoredTheme = theme => localStorage.setItem('theme', theme);

    const getPreferredTheme = () => {
        const stored = getStoredTheme();
        if (stored) return stored;
        return window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light';
    };

    const setTheme = theme => {
        document.documentElement.setAttribute('data-bs-theme', theme);
        const darkIcon = document.getElementById('theme-toggle-dark-icon');
        const lightIcon = document.getElementById('theme-toggle-light-icon');

        if (!darkIcon || !lightIcon) return;

        if (theme === 'dark') {
            darkIcon.classList.remove('d-none');
            lightIcon.classList.add('d-none');
        } else {
            darkIcon.classList.add('d-none');
            lightIcon.classList.remove('d-none');
        }
    };

    setTheme(getPreferredTheme());

    const themeToggleBtn = document.getElementById('theme-toggle');
    if (themeToggleBtn) {
        themeToggleBtn.addEventListener('click', () => {
            const currentTheme = document.documentElement.getAttribute('data-bs-theme');
            const newTheme = currentTheme === 'dark' ? 'light' : 'dark';
            setStoredTheme(newTheme);
            setTheme(newTheme);
        });
    }

    // NAVBAR TOGGLE
    const navbarToggles = document.querySelectorAll('.navbar-toggler');
    navbarToggles.forEach(btn => {
        const targetId = btn.getAttribute('data-bs-target');
        const target = document.querySelector(targetId);
        if (!target) return;

        btn.addEventListener('click', () => {
            target.classList.toggle('d-none');
        });
    });

    // Auto-switch when system theme changes
    window.matchMedia('(prefers-color-scheme: dark)').addEventListener('change', () => {
        const stored = getStoredTheme();
        if (!stored) {
            setTheme(getPreferredTheme());
        }
    });
}

// ==========================================
// CERTIFICATES FILTER & LIGHTBOX MODULE
// ==========================================
window.certFilterState = {
    category: 'all',
    search: ''
};

window.filterCertificates = function(category, btnElement) {
    window.certFilterState.category = category || 'all';

    // Highlight active button across any matching container
    const allButtons = document.querySelectorAll('.cert-filter-btn');
    allButtons.forEach(btn => {
        const btnCat = btn.getAttribute('data-filter') || 'all';
        if (btnCat === window.certFilterState.category) {
            btn.classList.add('active');
        } else {
            btn.classList.remove('active');
        }
    });

    applyCertificateFiltering();
};

window.applyCertificateFiltering = function() {
    const category = window.certFilterState.category || 'all';
    const searchInput = document.getElementById('certSearchInput');
    const searchTerm = searchInput ? searchInput.value.trim().toLowerCase() : window.certFilterState.search;

    const items = document.querySelectorAll('.cert-item');
    let visibleCount = 0;

    items.forEach(item => {
        const itemCat = item.getAttribute('data-category') || '';
        const searchData = (item.getAttribute('data-search') || item.textContent || '').toLowerCase();

        // Support matching category directly or when "all" is selected
        const matchesCat = (category === 'all' || itemCat === category);
        const matchesSearch = (!searchTerm || searchData.indexOf(searchTerm) !== -1);

        if (matchesCat && matchesSearch) {
            item.style.setProperty('display', '', 'important');
            item.classList.remove('d-none');
            visibleCount++;
        } else {
            item.style.setProperty('display', 'none', 'important');
            item.classList.add('d-none');
        }
    });

    // Update Counter
    const counter = document.getElementById('certCounter');
    if (counter) {
        if (category === 'all' && !searchTerm) {
            counter.innerHTML = `Exibindo todos os <strong>${items.length}</strong> certificados`;
        } else {
            counter.innerHTML = `Exibindo <strong>${visibleCount}</strong> de <strong>${items.length}</strong> certificados`;
        }
    }

    // Update Empty State
    const emptyState = document.getElementById('certEmptyState');
    if (emptyState) {
        if (visibleCount === 0 && items.length > 0) {
            emptyState.classList.remove('d-none');
            emptyState.style.display = 'block';
        } else {
            emptyState.classList.add('d-none');
            emptyState.style.display = 'none';
        }
    }
};

window.openCertLightbox = function(imgSrc, title) {
    let modal = document.getElementById('certLightboxModal');
    if (!modal) {
        modal = document.createElement('div');
        modal.id = 'certLightboxModal';
        modal.className = 'cert-lightbox';
        modal.innerHTML = `
            <div class="cert-lightbox-dialog">
                <button type="button" class="cert-lightbox-close" aria-label="Fechar visualização">&times;</button>
                <img id="certLightboxImg" src="" alt="Certificado" class="cert-lightbox-image">
                <div class="cert-lightbox-caption" id="certLightboxCaption"></div>
            </div>
        `;
        document.body.appendChild(modal);
    }

    const img = document.getElementById('certLightboxImg') || modal.querySelector('.cert-lightbox-image');
    const caption = document.getElementById('certLightboxCaption') || modal.querySelector('.cert-lightbox-caption');

    if (img && imgSrc) {
        img.src = imgSrc;
        img.alt = title || 'Certificado';
    }
    if (caption) {
        caption.textContent = title || '';
    }

    modal.classList.add('active');
    document.body.style.overflow = 'hidden';
};

window.closeCertLightbox = function() {
    const modal = document.getElementById('certLightboxModal');
    if (modal) {
        modal.classList.remove('active');
    }
    document.body.style.overflow = '';
};

// ==========================================
// GLOBAL EVENT DELEGATION
// Ensures handlers work even after dynamic DOM re-renders in Blazor
// ==========================================
document.addEventListener('click', function(e) {
    // 1. Filter button
    const filterBtn = e.target.closest('.cert-filter-btn');
    if (filterBtn) {
        e.preventDefault();
        const category = filterBtn.getAttribute('data-filter') || 'all';
        window.filterCertificates(category, filterBtn);
        return;
    }

    // 2. Open lightbox thumbnail or button
    const lightboxTrigger = e.target.closest('.cert-thumbnail-wrapper, .cert-open-btn, [data-open-lightbox]');
    if (lightboxTrigger) {
        e.preventDefault();
        const explicitSrc = lightboxTrigger.getAttribute('data-cert-src');
        const explicitTitle = lightboxTrigger.getAttribute('data-cert-title');
        
        const img = lightboxTrigger.querySelector('img');
        const src = explicitSrc || (img ? img.getAttribute('src') : null);
        const title = explicitTitle || (img ? img.getAttribute('alt') : '');

        if (src) {
            window.openCertLightbox(src, title);
        }
        return;
    }

    // 3. Close Lightbox (close button or backdrop click)
    if (e.target.closest('.cert-lightbox-close') || e.target.id === 'certLightboxModal' || e.target.classList.contains('cert-lightbox-dialog')) {
        window.closeCertLightbox();
        return;
    }
});

// Real-time Search Input delegation
document.addEventListener('input', function(e) {
    if (e.target && e.target.id === 'certSearchInput') {
        window.certFilterState.search = e.target.value.trim().toLowerCase();
        window.applyCertificateFiltering();
    }
});

// Escape key to close Lightbox
document.addEventListener('keydown', function(e) {
    if (e.key === 'Escape') {
        window.closeCertLightbox();
    }
});

// ==========================================
// LIFECYCLE HOOKS FOR BLAZOR ENHANCED NAV
// ==========================================
function initAll() {
    initializeTheme();
    if (typeof window.applyCertificateFiltering === 'function') {
        window.applyCertificateFiltering();
    }
}

if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', initAll);
} else {
    initAll();
}

window.addEventListener('JT_CMS:afterenhanced', initAll);
window.addEventListener('JT_CMS:init', initAll);
