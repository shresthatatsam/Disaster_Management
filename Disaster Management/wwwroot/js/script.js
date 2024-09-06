let currentTab = 0;

function showTab(tabIndex) {
    const tabs = document.querySelectorAll('.tab-pane');
    const nextButton = document.querySelectorAll('.next-button');
    const prevButton = document.querySelectorAll('.prev-button');

    tabs.forEach((tab, index) => {
        tab.classList.toggle('active', index === tabIndex);
    });

    nextButton.forEach(button => {
        button.style.display = tabIndex === tabs.length - 1 ? 'none' : 'inline-block';
    });

    prevButton.forEach(button => {
        button.style.display = tabIndex === 0 ? 'none' : 'inline-block';
    });

    if (tabIndex === 2) {
        // Populate review content
        document.getElementById('reviewContent').innerText = `
            First Name: ${document.getElementById('firstName').value}
            Last Name: ${document.getElementById('lastName').value}
            Email: ${document.getElementById('email').value}
            Phone Number: ${document.getElementById('phone').value}
        `;
    }
}

function nextTab() {
    const tabs = document.querySelectorAll('.tab-pane');
    if (currentTab < tabs.length - 1) {
        currentTab++;
        showTab(currentTab);
    }
}

function prevTab() {
    if (currentTab > 0) {
        currentTab--;
        showTab(currentTab);
    }
}

document.getElementById('tab-form').addEventListener('submit', (event) => {
    event.preventDefault();
    alert('Form submitted successfully!');
    // Handle form submission logic here (e.g., send data to the server)
});

// Initialize the first tab
showTab(currentTab);
