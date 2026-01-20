const API_BASE_URL = 'http://localhost:5086/api';

function formatDate(dateString) {
    const date = new Date(dateString);
    return date.toLocaleDateString('id-ID', {
        day: '2-digit',
        month: 'short',
        year: 'numeric'
    });
}

function validateNIK(nik) {
    return /^\d{16}$/.test(nik);
}

function showNotification(message, type = 'info') {
    const alertClass = {
        'success': 'alert-success',
        'error': 'alert-danger',
        'warning': 'alert-warning',
        'info': 'alert-info'
    }[type] || 'alert-info';

    const alertDiv = document.createElement('div');
    alertDiv.className = `alert ${alertClass} alert-dismissible fade show position-fixed top-0 end-0 m-3`;
    alertDiv.style.zIndex = '9999';
    alertDiv.innerHTML = `
        ${message}
        <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
    `;

    document.body.appendChild(alertDiv);

    setTimeout(() => {
        if (alertDiv.parentElement) {
            alertDiv.remove();
        }
    }, 5000);
}

async function checkAPIHealth() {
    try {
        const response = await fetch(`${API_BASE_URL}/karyawan`);
        return response.ok;
    } catch (error) {
        return false;
    }
}

window.KaryawanApp = {
    formatDate,
    validateNIK,
    showNotification,
    checkAPIHealth,
    API_BASE_URL
};